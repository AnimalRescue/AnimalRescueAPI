/*
 * Simple Inventory API
 *
 * This is a simple API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: you@your-company.com
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
{         /// <summary>
        /// Gets or Sets CatBreeds
        /// </summary>
        public enum CatBreeds
        { 
            /// <summary>
            /// Enum UndeterminedEnum for "Undetermined"
            /// </summary>
            [EnumMember(Value = "Undetermined")]
            UndeterminedEnum = 1,
            
            /// <summary>
            /// Enum AbyssinianEnum for "Abyssinian"
            /// </summary>
            [EnumMember(Value = "Abyssinian")]
            AbyssinianEnum = 2,
            
            /// <summary>
            /// Enum AmericanCurlEnum for "American Curl"
            /// </summary>
            [EnumMember(Value = "American Curl")]
            AmericanCurlEnum = 3,
            
            /// <summary>
            /// Enum BengalEnum for "Bengal"
            /// </summary>
            [EnumMember(Value = "Bengal")]
            BengalEnum = 4,
            
            /// <summary>
            /// Enum DomesticLonghairEnum for "Domestic Longhair"
            /// </summary>
            [EnumMember(Value = "Domestic Longhair")]
            DomesticLonghairEnum = 5,
            
            /// <summary>
            /// Enum DomesticMediumhairEnum for "Domestic Mediumhair"
            /// </summary>
            [EnumMember(Value = "Domestic Mediumhair")]
            DomesticMediumhairEnum = 6,
            
            /// <summary>
            /// Enum DomesticShorthairEnum for "Domestic Shorthair"
            /// </summary>
            [EnumMember(Value = "Domestic Shorthair")]
            DomesticShorthairEnum = 7,
            
            /// <summary>
            /// Enum FoldEnum for "Fold"
            /// </summary>
            [EnumMember(Value = "Fold")]
            FoldEnum = 8,
            
            /// <summary>
            /// Enum HimalayanEnum for "Himalayan"
            /// </summary>
            [EnumMember(Value = "Himalayan")]
            HimalayanEnum = 9,
            
            /// <summary>
            /// Enum MaineCoonEnum for "Maine Coon"
            /// </summary>
            [EnumMember(Value = "Maine Coon")]
            MaineCoonEnum = 10,
            
            /// <summary>
            /// Enum ManxEnum for "Manx"
            /// </summary>
            [EnumMember(Value = "Manx")]
            ManxEnum = 11,
            
            /// <summary>
            /// Enum PersianEnum for "Persian"
            /// </summary>
            [EnumMember(Value = "Persian")]
            PersianEnum = 12,
            
            /// <summary>
            /// Enum RagaMuffinEnum for "RagaMuffin"
            /// </summary>
            [EnumMember(Value = "RagaMuffin")]
            RagaMuffinEnum = 13,
            
            /// <summary>
            /// Enum RagdollEnum for "Ragdoll"
            /// </summary>
            [EnumMember(Value = "Ragdoll")]
            RagdollEnum = 14,
            
            /// <summary>
            /// Enum RussianBlueEnum for "Russian Blue"
            /// </summary>
            [EnumMember(Value = "Russian Blue")]
            RussianBlueEnum = 15,
            
            /// <summary>
            /// Enum SiameseEnum for "Siamese"
            /// </summary>
            [EnumMember(Value = "Siamese")]
            SiameseEnum = 16,
            
            /// <summary>
            /// Enum SnowshoeEnum for "Snowshoe"
            /// </summary>
            [EnumMember(Value = "Snowshoe")]
            SnowshoeEnum = 17,
            
            /// <summary>
            /// Enum SphynxEnum for "Sphynx"
            /// </summary>
            [EnumMember(Value = "Sphynx")]
            SphynxEnum = 18
        }
}
