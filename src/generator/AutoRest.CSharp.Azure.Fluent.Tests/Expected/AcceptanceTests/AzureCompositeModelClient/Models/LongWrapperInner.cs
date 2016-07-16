// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureCompositeModelClient.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class LongWrapperInner
    {
        /// <summary>
        /// Initializes a new instance of the LongWrapperInner class.
        /// </summary>
        public LongWrapperInner() { }

        /// <summary>
        /// Initializes a new instance of the LongWrapperInner class.
        /// </summary>
        public LongWrapperInner(long? field1 = default(long?), long? field2 = default(long?))
        {
            Field1 = field1;
            Field2 = field2;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "field1")]
        public long? Field1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "field2")]
        public long? Field2 { get; set; }

    }
}