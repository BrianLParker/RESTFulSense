// ---------------------------------------------------------------
// Copyright (c) Hassan Habib
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Reflection;
using Moq;
using RESTFulSense.Brokers.Reflections;
using RESTFulSense.Models.Attributes;
using RESTFulSense.Services;
using Tynamix.ObjectFiller;

namespace RESTFulSense.Tests.Services
{
    public partial class FormContentServiceTests
    {
        private readonly Mock<IReflectionBroker> reflectionBrokerMock;

        private readonly IFormContentService formContentService;

        public FormContentServiceTests()
        {
            this.reflectionBrokerMock = new Mock<IReflectionBroker>();
            this.formContentService = new FormContentService(reflectionBrokerMock.Object);
        }

        private object CreateRandomInputObject()
        {
            dynamic propertyInfo = new 
            {
                Name = CreateRandomString(),
                AttributeType = CreateRandomAttributeType(),
            };
        }
        private static string CreateRandomString() =>
            new MnemonicString().GetValue();


        private Type CreateRandomAttributeType()
        {
            Type[] types = new Type[]
            {
                typeof(RESTFulFileContentNameAttribute),
                typeof(RESTFulFileContentStreamAttribute),
                typeof(RESTFulStringContentAttribute)
            };

            int randomIndex = new IntRange(min: 0, max: 2).GetValue();

            return types[randomIndex];
        }


    }
}
