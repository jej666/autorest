// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureCompositeModelClient.Models
{
    using AcceptanceTestsAzureCompositeModelClient;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ReadonlyObj
    {
        /// <summary>
        /// Initializes a new instance of the ReadonlyObj class.
        /// </summary>
        public ReadonlyObj() { }

        /// <summary>
        /// Initializes a new instance of the ReadonlyObj class.
        /// </summary>
        public ReadonlyObj(string id = default(string), int? size = default(int?))
        {
            Id = id;
            Size = size;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; protected set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public int? Size { get; set; }

    }
}

