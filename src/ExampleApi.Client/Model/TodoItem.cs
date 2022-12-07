/*
 * ToDo API
 *
 * An ASP.NET Core Web API for managing ToDo items
 *
 * The version of the OpenAPI document: v1.2.2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ExampleApi.Client.Client.OpenAPIDateConverter;

namespace ExampleApi.Client.Model
{
    /// <summary>
    /// TodoItem
    /// </summary>
    [DataContract(Name = "TodoItem")]
    public partial class TodoItem : IEquatable<TodoItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TodoItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TodoItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TodoItem" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name (required).</param>
        /// <param name="isComplete">isComplete (default to false).</param>
        public TodoItem(long id = default(long), string name = default(string), bool isComplete = false)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TodoItem and cannot be null");
            }
            this.Name = name;
            this.Id = id;
            this.IsComplete = isComplete;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IsComplete
        /// </summary>
        [DataMember(Name = "isComplete", EmitDefaultValue = true)]
        public bool IsComplete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TodoItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsComplete: ").Append(IsComplete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TodoItem);
        }

        /// <summary>
        /// Returns true if TodoItem instances are equal
        /// </summary>
        /// <param name="input">Instance of TodoItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TodoItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsComplete == input.IsComplete ||
                    this.IsComplete.Equals(input.IsComplete)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsComplete.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
