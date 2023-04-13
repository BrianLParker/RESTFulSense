// ---------------------------------------------------------------
// Copyright (c) Hassan Habib
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System.Net.Http;

namespace RESTFulSense.Services
{
    internal interface IFormContentService
    {
        MultipartFormDataContent CreateMultipartFormDataContent(object @object);
    }
}
