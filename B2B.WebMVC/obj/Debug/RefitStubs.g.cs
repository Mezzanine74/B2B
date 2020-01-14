﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using B2B.SharedKernel;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace B2B.WebMVC.RefitInternalGenerated
{
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

namespace B2B.WebMVC.Helpers.EndPoints
{
    using B2B.WebMVC.RefitInternalGenerated;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedIAppUserEndPoint : IAppUserEndPoint
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIAppUserEndPoint(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<LoginResponseModel> IAppUserEndPoint.Login(LoginRequestModel model)
        {
            var arguments = new object[] { model };
            var func = requestBuilder.BuildRestResultFuncForMethod("Login", new Type[] { typeof(LoginRequestModel) });
            return (Task<LoginResponseModel>)func(Client, arguments);
        }
    }
}

namespace B2B.WebMVC.Helpers.EndPoints
{
    using B2B.WebMVC.RefitInternalGenerated;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedIEndPoints<TViewModel>
     : IEndPoints<TViewModel>
        where TViewModel: class, IEntity

    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIEndPoints(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<List<TViewModel>> IEndPoints<TViewModel>.List(string authorization)
        {
            var arguments = new object[] { authorization };
            var func = requestBuilder.BuildRestResultFuncForMethod("List", new Type[] { typeof(string) });
            return (Task<List<TViewModel>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<TViewModel> IEndPoints<TViewModel>.GetById(string authorization, int id)
        {
            var arguments = new object[] { authorization, id };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetById", new Type[] { typeof(string), typeof(int) });
            return (Task<TViewModel>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<OperationResult> IEndPoints<TViewModel>.Add(string authorization, TViewModel model)
        {
            var arguments = new object[] { authorization, model };
            var func = requestBuilder.BuildRestResultFuncForMethod("Add", new Type[] { typeof(string), typeof(TViewModel) });
            return (Task<OperationResult>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<OperationResult> IEndPoints<TViewModel>.Update(string authorization, TViewModel model)
        {
            var arguments = new object[] { authorization, model };
            var func = requestBuilder.BuildRestResultFuncForMethod("Update", new Type[] { typeof(string), typeof(TViewModel) });
            return (Task<OperationResult>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<OperationResult> IEndPoints<TViewModel>.Delete(string authorization, int id)
        {
            var arguments = new object[] { authorization, id };
            var func = requestBuilder.BuildRestResultFuncForMethod("Delete", new Type[] { typeof(string), typeof(int) });
            return (Task<OperationResult>)func(Client, arguments);
        }
    }
}
