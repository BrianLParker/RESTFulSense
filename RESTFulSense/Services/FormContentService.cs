// ---------------------------------------------------------------
// Copyright (c) Hassan Habib
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System.Net.Http;
using RESTFulSense.Brokers.Reflections;

namespace RESTFulSense.Services
{
    internal class FormContentService : IFormContentService
    {
        private readonly IReflectionBroker reflectionBroker;

        public FormContentService(IReflectionBroker reflectionBroker) => 
            this.reflectionBroker = reflectionBroker;

        public MultipartFormDataContent CreateMultipartFormDataContent(object @object) =>
            throw new System.NotImplementedException();
    }
}
