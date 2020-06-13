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
    public partial class ArrayOfStorySetNumbersInner : IEquatable<ArrayOfStorySetNumbersInner>
    { 
        /// <summary>
        /// ID of the Story Set Number
        /// </summary>
        /// <value>ID of the Story Set Number</value>
        [DataMember(Name="StorySetId")]
        public string StorySetId { get; set; }

        /// <summary>
        /// Gets or Sets SetNumber
        /// </summary>
        [DataMember(Name="SetNumber")]
        public decimal? SetNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArrayOfStorySetNumbersInner {\n");
            sb.Append("  StorySetId: ").Append(StorySetId).Append("\n");
            sb.Append("  SetNumber: ").Append(SetNumber).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ArrayOfStorySetNumbersInner)obj);
        }

        /// <summary>
        /// Returns true if ArrayOfStorySetNumbersInner instances are equal
        /// </summary>
        /// <param name="other">Instance of ArrayOfStorySetNumbersInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArrayOfStorySetNumbersInner other)
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
                    SetNumber == other.SetNumber ||
                    SetNumber != null &&
                    SetNumber.Equals(other.SetNumber)
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
                    if (SetNumber != null)
                    hashCode = hashCode * 59 + SetNumber.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ArrayOfStorySetNumbersInner left, ArrayOfStorySetNumbersInner right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ArrayOfStorySetNumbersInner left, ArrayOfStorySetNumbersInner right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
