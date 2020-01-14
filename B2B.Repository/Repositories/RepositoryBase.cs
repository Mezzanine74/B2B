using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using B2B.Data.Db;
using B2B.SharedKernel;

namespace B2B.Repository.Repositories
{
    public class RepositoryBase<TViewModel, TModel> : IRepository<TViewModel, TModel> where TViewModel : class, IEntity where TModel : class, IEntity
    {
        public B2BEntities db;
        public GenericRepository<TModel> repo;

        MapperConfiguration _config1, _config2;

        public RepositoryBase()
        {
            db = new B2BEntities();
            repo = new GenericRepository<TModel>(db);

            _config1 = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TViewModel, TModel>();
            });

            _config2 = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TModel, TViewModel>();
            });
        }

        public OperationResult Add(TViewModel vm)
        {

            IMapper iMapper = _config1.CreateMapper();

            var model = iMapper.Map<TViewModel, TModel>(vm);

            var _result = repo.Add(model);

            if (_result.Success)
            {
                _result.AddMessage(model.Id.ToString());

                // Repo eklerken MLId ye baksin. Eger buluyorsa o degeri PK ile ayni yapsin.

                var modelType = model.GetType();
                var PropertiesArray = modelType.GetProperties();

                foreach (var propertyInfo in PropertiesArray.Where(c => c.Name.Contains("MLId")))
                {
                    PropertyInfo pInfo = model.GetType().GetProperty(propertyInfo.Name); // DescriptionMLId
                    pInfo.SetValue(model, Convert.ChangeType((int?)model.Id, pInfo.PropertyType), null);
                }

                // Update all MLId columns based on PK
                repo.Update(model);

                // Add ML Descriptions to Sub Table
                // Loop model properties
                var mType = model.GetType();
                var pArray = mType.GetProperties();

                foreach (var propertyInfo in pArray.Where(c => c.Name.Contains("MLId")))
                {
                    // Access to related property. <for DescriptionMLId find Description>
                    Type myType = typeof(TModel);
                    string multiLangText = propertyInfo.Name.Replace("MLId", "");
                    PropertyInfo myPropInfo = myType.GetProperty(multiLangText);
                    var propertyValue = myPropInfo.GetValue(model, null);

                    // Add this value to SubTable
                    var propertyNavigationFullName = myType.Namespace + ".Sub" + model.GetType().Name + multiLangText;
                    Assembly assem = typeof(MockUpClass).Assembly;
                    Type className = assem.GetType(propertyNavigationFullName, true);
                    IEntitySubMultiLang inst = (IEntitySubMultiLang)Activator.CreateInstance(className);

                    // degerleri ver
                    inst.Description = propertyValue.ToString(); // parametreden gelecek;
                    inst.BaseId = model.Id; // parametreden gelecek;
                    inst.Lang = SessionClass.Session; // parametreden gelecek

                    // GenericRepository olustur
                    Type genericClass = typeof(GenericRepositorySubMultiLang<>);
                    Type constructedClass = genericClass.MakeGenericType(className);

                    var created = Activator.CreateInstance(constructedClass, db);

                    MethodInfo getAllMethod = constructedClass.GetMethod("Add", new Type[] { className });
                    getAllMethod.Invoke(created, new object[] { inst });
                }

            }
            else
            {
                _result.AddMessage("0");
            }

            return _result;

        }

        public TViewModel GetById(int id = 0)
        {
            var model = repo.FindByKey(id);

            IMapper iMapper = _config2.CreateMapper();

            return iMapper.Map<TModel, TViewModel>(model); ;
        }

        public virtual IEnumerable<TViewModel> List()
        {
            IMapper iMapper = _config2.CreateMapper();

            return repo.All().Select(c => iMapper.Map<TModel, TViewModel>(c)).ToList(); // ToList() olarak dondermezsen Gridviewde sorun yasiyorsun
        }

        public OperationResult Update(TViewModel vm)
        {
            IMapper iMapper = _config1.CreateMapper();

            var model = iMapper.Map<TViewModel, TModel>(vm);

            var _result = repo.Update(model);

            if (_result.Success)
            {

                // Repo eklerken MLId ye baksin. Eger buluyorsa o degeri PK ile ayni yapsin.
                var modelType = model.GetType();
                var PropertiesArray = modelType.GetProperties();

                foreach (var propertyInfo in PropertiesArray.Where(c => c.Name.Contains("MLId")))
                {
                    PropertyInfo pInfo = model.GetType().GetProperty(propertyInfo.Name); // DescriptionMLId
                    pInfo.SetValue(model, Convert.ChangeType((int?)model.Id, pInfo.PropertyType), null);
                }

                // Update all MLId columns based on PK
                repo.Update(model);

                // Add ML Descriptions to Sub Table
                // Loop model properties
                var mType = model.GetType();
                var pArray = mType.GetProperties();

                foreach (var propertyInfo in pArray.Where(c => c.Name.Contains("MLId")))
                {
                    // Access to related property. <for DescriptionMLId find Description>
                    Type myType = typeof(TModel);
                    string multiLangText = propertyInfo.Name.Replace("MLId", "");
                    PropertyInfo myPropInfo = myType.GetProperty(multiLangText);
                    var propertyValue = myPropInfo.GetValue(model, null);

                    // Update this value on SubTable
                    var propertyNavigationFullName = myType.Namespace + ".Sub" + model.GetType().Name + multiLangText;
                    Assembly assem = typeof(MockUpClass).Assembly;
                    Type typeName = assem.GetType(propertyNavigationFullName, true);

                    Type genCls = typeof(GenericRepositorySubMultiLang<>);
                    Type conCls = genCls.MakeGenericType(typeName); // bu var
                    var crtd = Activator.CreateInstance(conCls, db);

                    MethodInfo gA = conCls.GetMethod("FindByKey", new Type[] { typeof(Int32), typeof(string) });
                    IEntitySubMultiLang inst = (IEntitySubMultiLang)gA.Invoke(crtd, new object[] { vm.Id, SessionClass.Session });

                    // degerleri ver
                    inst.Description = propertyValue.ToString(); // parametreden gelecek;
                    inst.BaseId = vm.Id;
                    inst.Lang = SessionClass.Session;

                    // GenericRepository olustur
                    Type genericClass = typeof(GenericRepositorySubMultiLang<>);
                    Type constructedClass = genericClass.MakeGenericType(typeName);

                    var created = Activator.CreateInstance(constructedClass, db);

                    MethodInfo getAllMethod = constructedClass.GetMethod("Update", new Type[] { typeName });
                    getAllMethod.Invoke(created, new object[] { inst });
                }

            }
            else
            {
                _result.AddMessage("0");
            }

            return _result;

        }

        public OperationResult Delete(int id)
        {
            return repo.Remove(id);
        }

        public IEnumerable<TViewModel> ListWhere(Expression<Func<TModel, bool>> includeProperties)
        {
            IMapper iMapper = _config2.CreateMapper();

            return repo.AllInclude(includeProperties).Select(c => iMapper.Map<TModel, TViewModel>(c));
        }

    }
}
