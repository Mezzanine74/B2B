using B2B.SharedKernel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using B2B.Data.Db;
using System.Dynamic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace B2B.WebMVC.Helpers
{

// Id ve Description kolonlari zorunlu olmali
// ManyToMany iliski tablosunda PK "Id" kolonu olacak.

    public class FKandNavigationFromModel<T> where T : class, IEntity
    {
        private B2BEntities _db;
        private T _model;
        private Assembly _assem;
        private DbSet<T> _dbSet;

        public FKandNavigationFromModel(T model)
        {
            _db = new B2BEntities();
            _dbSet = _db.Set<T>();
            _model = model;
            _assem = typeof(MockUpClass).Assembly;
        }

        public List<FKandNavigationProperty> GetList()
        {
            var list = new List<FKandNavigationProperty>();

            var fKs = GetFKPropertyNames();
            var navigations = GetNavigationProperties(_model);

            foreach (var fK in fKs)
            {
                var expectedNavigationName = fK.Substring(0, fK.Length - 2); // removes Id from string, eg: SupplierId > Supplier

                foreach (var propertyInfo in navigations.Where(c => c.PropertyType.Name == expectedNavigationName))
                {
                    var className = _assem.GetType(propertyInfo.PropertyType.FullName, true);

                    var dbSetMethodInfo = typeof(DbContext).GetMethods().FirstOrDefault(method => method.Name == "Set" && method.IsGenericMethod == true);

                    dynamic dbSet = new ExpandoObject();

                    dbSet = dbSetMethodInfo.MakeGenericMethod(className).Invoke(_db, null);

                    var liste = Enumerable.ToList(dbSet);

                    var valueField = "Id";// className.GetProperties()[0].Name;
                    var textField = "Description"; //className.GetProperties()[1].Name;

                    list.Add(new FKandNavigationProperty()
                    {
                        FK = fK,
                        Navigation = propertyInfo,
                        Repo = liste,
                        TextField = textField,
                        ValueField = valueField

                    });

                }

            }

            return list;
        }

        public IEnumerable<string> GetFKPropertyNames()
        {
            ObjectContext objectContext = ((IObjectContextAdapter)_db).ObjectContext;
            ObjectSet<T> set = objectContext.CreateObjectSet<T>();
            var Fks = set.EntitySet.ElementType.NavigationProperties.SelectMany(n => n.GetDependentProperties());

            return Fks.Select(fk => fk.Name);
        }

        public List<PropertyInfo> GetNavigationProperties(T entry)
        {
            List<PropertyInfo> properties = new List<PropertyInfo>();
            Type entityType = entry.GetType();

            var entitySetElementType = ((IObjectContextAdapter)_db).ObjectContext.CreateObjectSet<T>().EntitySet.ElementType;

            foreach (var navigationProperty in entitySetElementType.NavigationProperties)
            {
                properties.Add(entityType.GetProperty(navigationProperty.Name));
            }
            return properties;
        }
    }
}