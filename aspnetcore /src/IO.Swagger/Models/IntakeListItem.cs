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
    /// Item of IntakeList
    /// </summary>
    [DataContract]
    public partial class IntakeListItem :  IEquatable<IntakeListItem>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public IntakeId Id { get; set; }

        /// <summary>
        /// Gets or Sets ParNumber
        /// </summary>
        [DataMember(Name="parNumber")]
        public ParNumber ParNumber { get; set; }

        /// <summary>
        /// Gets or Sets DateOfIntake
        /// </summary>
        [DataMember(Name="dateOfIntake")]
        public DateTime? DateOfIntake { get; set; }

        /// <summary>
        /// Gets or Sets AnimalId
        /// </summary>
        [DataMember(Name="animalId")]
        public AnimalId AnimalId { get; set; }

        /// <summary>
        /// Gets or Sets AnimalName
        /// </summary>
        [DataMember(Name="animalName")]
        public string AnimalName { get; set; }

        /// <summary>
        /// Gets or Sets IsInIsolation
        /// </summary>
        [DataMember(Name="isInIsolation")]
        public bool? IsInIsolation { get; set; }

        /// <summary>
        /// Gets or Sets AdoptionStatus
        /// </summary>
        [DataMember(Name="adoptionStatus")]
        public string AdoptionStatus { get; set; }

        /// <summary>
        /// Gets or Sets KennelName
        /// </summary>
        [DataMember(Name="kennelName")]
        public string KennelName { get; set; }

        /// <summary>
        /// Gets or Sets KennelId
        /// </summary>
        [DataMember(Name="kennelId")]
        public KennelId KennelId { get; set; }

        /// <summary>
        /// Gets or Sets RoomName
        /// </summary>
        [DataMember(Name="roomName")]
        public string RoomName { get; set; }

        /// <summary>
        /// Gets or Sets RoomId
        /// </summary>
        [DataMember(Name="roomId")]
        public RoomId RoomId { get; set; }

        /// <summary>
        /// Gets or Sets BuildingName
        /// </summary>
        [DataMember(Name="buildingName")]
        public string BuildingName { get; set; }

        /// <summary>
        /// Gets or Sets BuildingId
        /// </summary>
        [DataMember(Name="buildingId")]
        public BuildingId BuildingId { get; set; }

        /// <summary>
        /// Gets or Sets LocationName
        /// </summary>
        [DataMember(Name="locationName")]
        public string LocationName { get; set; }

        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name="locationId")]
        public LocationId LocationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntakeListItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ParNumber: ").Append(ParNumber).Append("\n");
            sb.Append("  DateOfIntake: ").Append(DateOfIntake).Append("\n");
            sb.Append("  AnimalId: ").Append(AnimalId).Append("\n");
            sb.Append("  AnimalName: ").Append(AnimalName).Append("\n");
            sb.Append("  IsInIsolation: ").Append(IsInIsolation).Append("\n");
            sb.Append("  AdoptionStatus: ").Append(AdoptionStatus).Append("\n");
            sb.Append("  KennelName: ").Append(KennelName).Append("\n");
            sb.Append("  KennelId: ").Append(KennelId).Append("\n");
            sb.Append("  RoomName: ").Append(RoomName).Append("\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  BuildingName: ").Append(BuildingName).Append("\n");
            sb.Append("  BuildingId: ").Append(BuildingId).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((IntakeListItem)obj);
        }

        /// <summary>
        /// Returns true if IntakeListItem instances are equal
        /// </summary>
        /// <param name="other">Instance of IntakeListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntakeListItem other)
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
                    ParNumber == other.ParNumber ||
                    ParNumber != null &&
                    ParNumber.Equals(other.ParNumber)
                ) && 
                (
                    DateOfIntake == other.DateOfIntake ||
                    DateOfIntake != null &&
                    DateOfIntake.Equals(other.DateOfIntake)
                ) && 
                (
                    AnimalId == other.AnimalId ||
                    AnimalId != null &&
                    AnimalId.Equals(other.AnimalId)
                ) && 
                (
                    AnimalName == other.AnimalName ||
                    AnimalName != null &&
                    AnimalName.Equals(other.AnimalName)
                ) && 
                (
                    IsInIsolation == other.IsInIsolation ||
                    IsInIsolation != null &&
                    IsInIsolation.Equals(other.IsInIsolation)
                ) && 
                (
                    AdoptionStatus == other.AdoptionStatus ||
                    AdoptionStatus != null &&
                    AdoptionStatus.Equals(other.AdoptionStatus)
                ) && 
                (
                    KennelName == other.KennelName ||
                    KennelName != null &&
                    KennelName.Equals(other.KennelName)
                ) && 
                (
                    KennelId == other.KennelId ||
                    KennelId != null &&
                    KennelId.Equals(other.KennelId)
                ) && 
                (
                    RoomName == other.RoomName ||
                    RoomName != null &&
                    RoomName.Equals(other.RoomName)
                ) && 
                (
                    RoomId == other.RoomId ||
                    RoomId != null &&
                    RoomId.Equals(other.RoomId)
                ) && 
                (
                    BuildingName == other.BuildingName ||
                    BuildingName != null &&
                    BuildingName.Equals(other.BuildingName)
                ) && 
                (
                    BuildingId == other.BuildingId ||
                    BuildingId != null &&
                    BuildingId.Equals(other.BuildingId)
                ) && 
                (
                    LocationName == other.LocationName ||
                    LocationName != null &&
                    LocationName.Equals(other.LocationName)
                ) && 
                (
                    LocationId == other.LocationId ||
                    LocationId != null &&
                    LocationId.Equals(other.LocationId)
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
                    if (ParNumber != null)
                    hashCode = hashCode * 59 + ParNumber.GetHashCode();
                    if (DateOfIntake != null)
                    hashCode = hashCode * 59 + DateOfIntake.GetHashCode();
                    if (AnimalId != null)
                    hashCode = hashCode * 59 + AnimalId.GetHashCode();
                    if (AnimalName != null)
                    hashCode = hashCode * 59 + AnimalName.GetHashCode();
                    if (IsInIsolation != null)
                    hashCode = hashCode * 59 + IsInIsolation.GetHashCode();
                    if (AdoptionStatus != null)
                    hashCode = hashCode * 59 + AdoptionStatus.GetHashCode();
                    if (KennelName != null)
                    hashCode = hashCode * 59 + KennelName.GetHashCode();
                    if (KennelId != null)
                    hashCode = hashCode * 59 + KennelId.GetHashCode();
                    if (RoomName != null)
                    hashCode = hashCode * 59 + RoomName.GetHashCode();
                    if (RoomId != null)
                    hashCode = hashCode * 59 + RoomId.GetHashCode();
                    if (BuildingName != null)
                    hashCode = hashCode * 59 + BuildingName.GetHashCode();
                    if (BuildingId != null)
                    hashCode = hashCode * 59 + BuildingId.GetHashCode();
                    if (LocationName != null)
                    hashCode = hashCode * 59 + LocationName.GetHashCode();
                    if (LocationId != null)
                    hashCode = hashCode * 59 + LocationId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(IntakeListItem left, IntakeListItem right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IntakeListItem left, IntakeListItem right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
