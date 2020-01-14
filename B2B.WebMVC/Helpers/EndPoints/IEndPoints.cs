using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using B2B.SharedKernel;
using Refit;

namespace B2B.WebMVC.Helpers.EndPoints
{
    public interface IEndPoints<TViewModel> where TViewModel: class, IEntity 
    {
        [Get( "/api/Test/List")]
        Task<List<TViewModel>> List([Header("Authorization")] string authorization);

        [Get("/api/Test/GetById/{id}")]
        Task<TViewModel> GetById([Header("Authorization")] string authorization, int id);

        [Post("/api/Test/Add")]
        Task<OperationResult> Add([Header("Authorization")] string authorization, TViewModel model);

        [Post("/api/Test/Update")]
        Task<OperationResult> Update([Header("Authorization")] string authorization, TViewModel model);

        [Post("/api/Test/Delete/{id}")]
        Task<OperationResult> Delete([Header("Authorization")] string authorization, int id);
    }
}