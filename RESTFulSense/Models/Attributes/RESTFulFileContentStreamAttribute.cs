// ---------------------------------------------------------------
// Copyright (c) Hassan Habib
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;

namespace RESTFulSense.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RESTFulFileContentStreamAttribute : Attribute
    {
        public RESTFulFileContentStreamAttribute(string name) =>
            Name = name;

        public string Name { get; }
    }
}
