using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace B2B.WebMVC.Helpers.EndPoints
{
    public interface IAppUserEndPoint
    {

        //[Get("/AppUsers/GetUsers")]
        //Task<List<AppUserResponseModel>> GetAll([Header("Authorization")] string authorization);

        //[Get("/AppUsers/GetActiveUsers")]
        //Task<List<AppUserResponseModel>> GetActive();
        //[Get("/AppUsers/AppUsers/{id}")]
        //Task<AppUserResponseModel> GetById([Header("Authorization")] string authorization, Guid Id);
        //[Put("/AppUsers/AppUsers/{id}")]
        //Task<AppUserResponseModel> Update([Header("Authorization")] string authorization, Guid id, AppUserRequestModel item);
        //[Post("/AppUsers/AppUsers")]
        //Task<AppUserResponseModel> Add(AppUserRequestModel item);
        //[Delete("/AppUsers/AppUsers/{id}")]
        //Task Remove([Header("Authorization")] string authorization, Guid id);
        //[Get("/AppUsers/AppUserExists/{id}")]
        //Task<bool> AppUserExists([Header("Authorization")] string authorization, Guid id);
        //[Get("/AppUsers/CheckCredentials/{username}/{password}")]
        //Task<bool> CheckCredentials([Header("Authorization")] string authorization, string username, string password);
        //[Get("/AppUsers/FindbyUserName/{username}")]
        //Task<AppUserResponseModel> FindbyUserName([Header("Authorization")] string authorization, string username);
        [Post("/token")]
        Task<LoginResponseModel> Login([Body(BodySerializationMethod.UrlEncoded)] LoginRequestModel model);
    }
}
