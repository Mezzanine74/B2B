using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using B2B.SharedKernel;

namespace B2B.Repository
{
    public interface IRepository<TViewModel, TModel> where TViewModel : class, IEntity where TModel : class, IEntity
    {
        OperationResult Add(TViewModel vm);

        OperationResult Update(TViewModel vm);

        OperationResult Delete(int id);

        IEnumerable<TViewModel> List();

        TViewModel GetById(int id);

        IEnumerable<TViewModel> ListWhere(Expression<Func<TModel, bool>> includeProperties);
    }
}
