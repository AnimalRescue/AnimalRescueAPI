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
    public partial class AvailabilityScheduleDateRangeEnd :  IEquatable<AvailabilityScheduleDateRangeEnd>
    {         /// <summary>
        /// Gets or Sets Month
        /// </summary>
        public enum MonthSelect
        { 
            /// <summary>
            /// Enum JanuaryEnum for "January"
            /// </summary>
            [EnumMember(Value = "January")]
            JanuaryEnum = 1,
            
            /// <summary>
            /// Enum FebruaryEnum for "February"
            /// </summary>
            [EnumMember(Value = "February")]
            FebruaryEnum = 2,
            
            /// <summary>
            /// Enum MarchEnum for "March"
            /// </summary>
            [EnumMember(Value = "March")]
            MarchEnum = 3,
            
            /// <summary>
            /// Enum AprilEnum for "April"
            /// </summary>
            [EnumMember(Value = "April")]
            AprilEnum = 4,
            
            /// <summary>
            /// Enum MayEnum for "May"
            /// </summary>
            [EnumMember(Value = "May")]
            MayEnum = 5,
            
            /// <summary>
            /// Enum JuneEnum for "June"
            /// </summary>
            [EnumMember(Value = "June")]
            JuneEnum = 6,
            
            /// <summary>
            /// Enum JulyEnum for "July"
            /// </summary>
            [EnumMember(Value = "July")]
            JulyEnum = 7,
            
            /// <summary>
            /// Enum AugustEnum for "August"
            /// </summary>
            [EnumMember(Value = "August")]
            AugustEnum = 8,
            
            /// <summary>
            /// Enum SeptemberEnum for "September"
            /// </summary>
            [EnumMember(Value = "September")]
            SeptemberEnum = 9,
            
            /// <summary>
            /// Enum OctoberEnum for "October"
            /// </summary>
            [EnumMember(Value = "October")]
            OctoberEnum = 10,
            
            /// <summary>
            /// Enum NovemberEnum for "November"
            /// </summary>
            [EnumMember(Value = "November")]
            NovemberEnum = 11,
            
            /// <summary>
            /// Enum DecemberEnum for "December"
            /// </summary>
            [EnumMember(Value = "December")]
            DecemberEnum = 12
        }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name="month")]
        public MonthSelect? Month { get; set; }
        /// <summary>
        /// Gets or Sets DayOfMonth
        /// </summary>
        public enum DayOfMonthSelect
        { 
            /// <summary>
            /// Enum _1Enum for "1"
            /// </summary>
            [EnumMember(Value = "1")]
            _1Enum = 1,
            
            /// <summary>
            /// Enum _2Enum for "2"
            /// </summary>
            [EnumMember(Value = "2")]
            _2Enum = 2,
            
            /// <summary>
            /// Enum _3Enum for "3"
            /// </summary>
            [EnumMember(Value = "3")]
            _3Enum = 3,
            
            /// <summary>
            /// Enum _4Enum for "4"
            /// </summary>
            [EnumMember(Value = "4")]
            _4Enum = 4,
            
            /// <summary>
            /// Enum _5Enum for "5"
            /// </summary>
            [EnumMember(Value = "5")]
            _5Enum = 5,
            
            /// <summary>
            /// Enum _6Enum for "6"
            /// </summary>
            [EnumMember(Value = "6")]
            _6Enum = 6,
            
            /// <summary>
            /// Enum _7Enum for "7"
            /// </summary>
            [EnumMember(Value = "7")]
            _7Enum = 7,
            
            /// <summary>
            /// Enum _8Enum for "8"
            /// </summary>
            [EnumMember(Value = "8")]
            _8Enum = 8,
            
            /// <summary>
            /// Enum _9Enum for "9"
            /// </summary>
            [EnumMember(Value = "9")]
            _9Enum = 9,
            
            /// <summary>
            /// Enum _10Enum for "10"
            /// </summary>
            [EnumMember(Value = "10")]
            _10Enum = 10,
            
            /// <summary>
            /// Enum _11Enum for "11"
            /// </summary>
            [EnumMember(Value = "11")]
            _11Enum = 11,
            
            /// <summary>
            /// Enum _12Enum for "12"
            /// </summary>
            [EnumMember(Value = "12")]
            _12Enum = 12,
            
            /// <summary>
            /// Enum _13Enum for "13"
            /// </summary>
            [EnumMember(Value = "13")]
            _13Enum = 13,
            
            /// <summary>
            /// Enum _14Enum for "14"
            /// </summary>
            [EnumMember(Value = "14")]
            _14Enum = 14,
            
            /// <summary>
            /// Enum _15Enum for "15"
            /// </summary>
            [EnumMember(Value = "15")]
            _15Enum = 15,
            
            /// <summary>
            /// Enum _16Enum for "16"
            /// </summary>
            [EnumMember(Value = "16")]
            _16Enum = 16,
            
            /// <summary>
            /// Enum _17Enum for "17"
            /// </summary>
            [EnumMember(Value = "17")]
            _17Enum = 17,
            
            /// <summary>
            /// Enum _18Enum for "18"
            /// </summary>
            [EnumMember(Value = "18")]
            _18Enum = 18,
            
            /// <summary>
            /// Enum _19Enum for "19"
            /// </summary>
            [EnumMember(Value = "19")]
            _19Enum = 19,
            
            /// <summary>
            /// Enum _20Enum for "20"
            /// </summary>
            [EnumMember(Value = "20")]
            _20Enum = 20,
            
            /// <summary>
            /// Enum _21Enum for "21"
            /// </summary>
            [EnumMember(Value = "21")]
            _21Enum = 21,
            
            /// <summary>
            /// Enum _22Enum for "22"
            /// </summary>
            [EnumMember(Value = "22")]
            _22Enum = 22,
            
            /// <summary>
            /// Enum _23Enum for "23"
            /// </summary>
            [EnumMember(Value = "23")]
            _23Enum = 23,
            
            /// <summary>
            /// Enum _24Enum for "24"
            /// </summary>
            [EnumMember(Value = "24")]
            _24Enum = 24,
            
            /// <summary>
            /// Enum _25Enum for "25"
            /// </summary>
            [EnumMember(Value = "25")]
            _25Enum = 25,
            
            /// <summary>
            /// Enum _26Enum for "26"
            /// </summary>
            [EnumMember(Value = "26")]
            _26Enum = 26,
            
            /// <summary>
            /// Enum _27Enum for "27"
            /// </summary>
            [EnumMember(Value = "27")]
            _27Enum = 27,
            
            /// <summary>
            /// Enum _28Enum for "28"
            /// </summary>
            [EnumMember(Value = "28")]
            _28Enum = 28,
            
            /// <summary>
            /// Enum _29Enum for "29"
            /// </summary>
            [EnumMember(Value = "29")]
            _29Enum = 29,
            
            /// <summary>
            /// Enum _30Enum for "30"
            /// </summary>
            [EnumMember(Value = "30")]
            _30Enum = 30,
            
            /// <summary>
            /// Enum _31Enum for "31"
            /// </summary>
            [EnumMember(Value = "31")]
            _31Enum = 31
        }

        /// <summary>
        /// Gets or Sets DayOfMonth
        /// </summary>
        [DataMember(Name="dayOfMonth")]
        public DayOfMonthSelect? DayOfMonth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailabilityScheduleDateRangeEnd {\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  DayOfMonth: ").Append(DayOfMonth).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AvailabilityScheduleDateRangeEnd)obj);
        }

        /// <summary>
        /// Returns true if AvailabilityScheduleDateRangeEnd instances are equal
        /// </summary>
        /// <param name="other">Instance of AvailabilityScheduleDateRangeEnd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailabilityScheduleDateRangeEnd other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Month == other.Month ||
                    Month != null &&
                    Month.Equals(other.Month)
                ) && 
                (
                    DayOfMonth == other.DayOfMonth ||
                    DayOfMonth != null &&
                    DayOfMonth.Equals(other.DayOfMonth)
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
                    if (Month != null)
                    hashCode = hashCode * 59 + Month.GetHashCode();
                    if (DayOfMonth != null)
                    hashCode = hashCode * 59 + DayOfMonth.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AvailabilityScheduleDateRangeEnd left, AvailabilityScheduleDateRangeEnd right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AvailabilityScheduleDateRangeEnd left, AvailabilityScheduleDateRangeEnd right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
