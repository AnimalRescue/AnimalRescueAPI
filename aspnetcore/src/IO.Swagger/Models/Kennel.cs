/*
 * AnimalRescue API
 *
 * API for OSS AnimalRescue
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
    /// 
    /// </summary>
    [DataContract]
    public partial class Kennel :  IEquatable<Kennel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RoomId
        /// </summary>
        [Required]
        [DataMember(Name="roomId")]
        public Guid? RoomId { get; set; }
        /// <summary>
        /// Gets or Sets Species
        /// </summary>
        public enum Species
        { 
            /// <summary>
            /// Enum DogEnum for "Dog"
            /// </summary>
            [EnumMember(Value = "Dog")]
            DogEnum = 1,
            
            /// <summary>
            /// Enum CatEnum for "Cat"
            /// </summary>
            [EnumMember(Value = "Cat")]
            CatEnum = 2
        }

        /// <summary>
        /// Gets or Sets Species
        /// </summary>
        [DataMember(Name="species")]
        public Species? Species { get; set; }

        /// <summary>
        /// Gets or Sets MaxOccupancy
        /// </summary>
        [Required]
        [DataMember(Name="maxOccupancy")]
        public int? MaxOccupancy { get; set; }

        /// <summary>
        /// Gets or Sets Animals
        /// </summary>
        [DataMember(Name="animals")]
        public BaseAnimalInfo Animals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Kennel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  Species: ").Append(Species).Append("\n");
            sb.Append("  MaxOccupancy: ").Append(MaxOccupancy).Append("\n");
            sb.Append("  Animals: ").Append(Animals).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Kennel)obj);
        }

        /// <summary>
        /// Returns true if Kennel instances are equal
        /// </summary>
        /// <param name="other">Instance of Kennel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Kennel other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    RoomId == other.RoomId ||
                    RoomId != null &&
                    RoomId.Equals(other.RoomId)
                ) && 
                (
                    Species == other.Species ||
                    Species != null &&
                    Species.Equals(other.Species)
                ) && 
                (
                    MaxOccupancy == other.MaxOccupancy ||
                    MaxOccupancy != null &&
                    MaxOccupancy.Equals(other.MaxOccupancy)
                ) && 
                (
                    Animals == other.Animals ||
                    Animals != null &&
                    Animals.Equals(other.Animals)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (RoomId != null)
                    hashCode = hashCode * 59 + RoomId.GetHashCode();
                    if (Species != null)
                    hashCode = hashCode * 59 + Species.GetHashCode();
                    if (MaxOccupancy != null)
                    hashCode = hashCode * 59 + MaxOccupancy.GetHashCode();
                    if (Animals != null)
                    hashCode = hashCode * 59 + Animals.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Kennel left, Kennel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Kennel left, Kennel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
