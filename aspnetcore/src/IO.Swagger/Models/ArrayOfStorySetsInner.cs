/*
 * Stories and Story Sets Collection
 *
 * Endpoints for updating Stories of Tales App
 *
 * OpenAPI spec version: 0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ArrayOfStorySetsInner : IEquatable<ArrayOfStorySetsInner>
    { 
        /// <summary>
        /// ID of the Story Set
        /// </summary>
        /// <value>ID of the Story Set</value>
        [DataMember(Name="StorySetId")]
        public string StorySetId { get; set; }

        /// <summary>
        /// Gets or Sets StorySetName
        /// </summary>
        [DataMember(Name="StorySetName")]
        public string StorySetName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArrayOfStorySetsInner {\n");
            sb.Append("  StorySetId: ").Append(StorySetId).Append("\n");
            sb.Append("  StorySetName: ").Append(StorySetName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ArrayOfStorySetsInner)obj);
        }

        /// <summary>
        /// Returns true if ArrayOfStorySetsInner instances are equal
        /// </summary>
        /// <param name="other">Instance of ArrayOfStorySetsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArrayOfStorySetsInner other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    StorySetId == other.StorySetId ||
                    StorySetId != null &&
                    StorySetId.Equals(other.StorySetId)
                ) && 
                (
                    StorySetName == other.StorySetName ||
                    StorySetName != null &&
                    StorySetName.Equals(other.StorySetName)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (StorySetId != null)
                    hashCode = hashCode * 59 + StorySetId.GetHashCode();
                    if (StorySetName != null)
                    hashCode = hashCode * 59 + StorySetName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ArrayOfStorySetsInner left, ArrayOfStorySetsInner right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ArrayOfStorySetsInner left, ArrayOfStorySetsInner right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
