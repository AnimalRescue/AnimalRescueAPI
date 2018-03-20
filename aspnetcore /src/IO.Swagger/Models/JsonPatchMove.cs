/*
 * Animal Rescue API
 *
 * AnimalRescue CQRS API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: jlgartee@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
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
    /// move operation. \&quot;from\&quot; is a JSON Pointer.
    /// </summary>
    [DataContract]
    public partial class JsonPatchMove :  IEquatable<JsonPatchMove>
    {         /// <summary>
        /// Gets or Sets Op
        /// </summary>
        public enum OpEnum
        { 
            /// <summary>
            /// Enum MoveEnum for "move"
            /// </summary>
            [EnumMember(Value = "move")]
            MoveEnum = 1
        }

        /// <summary>
        /// Gets or Sets Op
        /// </summary>
        [Required]
        [DataMember(Name="op")]
        public OpEnum? Op { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [Required]
        [DataMember(Name="from")]
        public JsonPointer From { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonPatchMove {\n");
            sb.Append("  Op: ").Append(Op).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JsonPatchMove)obj);
        }

        /// <summary>
        /// Returns true if JsonPatchMove instances are equal
        /// </summary>
        /// <param name="other">Instance of JsonPatchMove to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonPatchMove other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Op == other.Op ||
                    Op != null &&
                    Op.Equals(other.Op)
                ) && 
                (
                    From == other.From ||
                    From != null &&
                    From.Equals(other.From)
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
                    if (Op != null)
                    hashCode = hashCode * 59 + Op.GetHashCode();
                    if (From != null)
                    hashCode = hashCode * 59 + From.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JsonPatchMove left, JsonPatchMove right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JsonPatchMove left, JsonPatchMove right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
