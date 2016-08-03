// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.MirrorSequences.Models
{
    using System.Linq;

    public partial class Pet
    {
        /// <summary>
        /// Initializes a new instance of the Pet class.
        /// </summary>
        public Pet() { }

        /// <summary>
        /// Initializes a new instance of the Pet class.
        /// </summary>
        public Pet(long id, string name, System.Collections.Generic.IList<PetStyle> styles = default(System.Collections.Generic.IList<PetStyle>), string tag = default(string))
        {
            Id = id;
            Name = name;
            Styles = styles;
            Tag = tag;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "styles")]
        public System.Collections.Generic.IList<PetStyle> Styles { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (this.Styles != null)
            {
                foreach (var element in this.Styles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}