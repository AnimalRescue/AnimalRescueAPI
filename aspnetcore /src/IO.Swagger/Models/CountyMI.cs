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
        /// Gets or Sets CountyMI
        /// </summary>
        public enum CountyMI
        { 
            /// <summary>
            /// Enum AlconaEnum for "Alcona"
            /// </summary>
            [EnumMember(Value = "Alcona")]
            AlconaEnum = 1,
            
            /// <summary>
            /// Enum AlgerEnum for "Alger"
            /// </summary>
            [EnumMember(Value = "Alger")]
            AlgerEnum = 2,
            
            /// <summary>
            /// Enum AlleganEnum for "Allegan"
            /// </summary>
            [EnumMember(Value = "Allegan")]
            AlleganEnum = 3,
            
            /// <summary>
            /// Enum AlpenaEnum for "Alpena"
            /// </summary>
            [EnumMember(Value = "Alpena")]
            AlpenaEnum = 4,
            
            /// <summary>
            /// Enum AntrimEnum for "Antrim"
            /// </summary>
            [EnumMember(Value = "Antrim")]
            AntrimEnum = 5,
            
            /// <summary>
            /// Enum ArenacEnum for "Arenac"
            /// </summary>
            [EnumMember(Value = "Arenac")]
            ArenacEnum = 6,
            
            /// <summary>
            /// Enum BaragaEnum for "Baraga"
            /// </summary>
            [EnumMember(Value = "Baraga")]
            BaragaEnum = 7,
            
            /// <summary>
            /// Enum BarryEnum for "Barry"
            /// </summary>
            [EnumMember(Value = "Barry")]
            BarryEnum = 8,
            
            /// <summary>
            /// Enum BayEnum for "Bay"
            /// </summary>
            [EnumMember(Value = "Bay")]
            BayEnum = 9,
            
            /// <summary>
            /// Enum BenzieEnum for "Benzie"
            /// </summary>
            [EnumMember(Value = "Benzie")]
            BenzieEnum = 10,
            
            /// <summary>
            /// Enum BerrienEnum for "Berrien"
            /// </summary>
            [EnumMember(Value = "Berrien")]
            BerrienEnum = 11,
            
            /// <summary>
            /// Enum BranchEnum for "Branch"
            /// </summary>
            [EnumMember(Value = "Branch")]
            BranchEnum = 12,
            
            /// <summary>
            /// Enum CalhounEnum for "Calhoun"
            /// </summary>
            [EnumMember(Value = "Calhoun")]
            CalhounEnum = 13,
            
            /// <summary>
            /// Enum CassEnum for "Cass"
            /// </summary>
            [EnumMember(Value = "Cass")]
            CassEnum = 14,
            
            /// <summary>
            /// Enum CharlevoixEnum for "Charlevoix"
            /// </summary>
            [EnumMember(Value = "Charlevoix")]
            CharlevoixEnum = 15,
            
            /// <summary>
            /// Enum CheboyganEnum for "Cheboygan"
            /// </summary>
            [EnumMember(Value = "Cheboygan")]
            CheboyganEnum = 16,
            
            /// <summary>
            /// Enum ChippewaEnum for "Chippewa"
            /// </summary>
            [EnumMember(Value = "Chippewa")]
            ChippewaEnum = 17,
            
            /// <summary>
            /// Enum ClareEnum for "Clare"
            /// </summary>
            [EnumMember(Value = "Clare")]
            ClareEnum = 18,
            
            /// <summary>
            /// Enum ClintonEnum for "Clinton"
            /// </summary>
            [EnumMember(Value = "Clinton")]
            ClintonEnum = 19,
            
            /// <summary>
            /// Enum CrawfordEnum for "Crawford"
            /// </summary>
            [EnumMember(Value = "Crawford")]
            CrawfordEnum = 20,
            
            /// <summary>
            /// Enum DeltaEnum for "Delta"
            /// </summary>
            [EnumMember(Value = "Delta")]
            DeltaEnum = 21,
            
            /// <summary>
            /// Enum DickinsonEnum for "Dickinson"
            /// </summary>
            [EnumMember(Value = "Dickinson")]
            DickinsonEnum = 22,
            
            /// <summary>
            /// Enum EatonEnum for "Eaton"
            /// </summary>
            [EnumMember(Value = "Eaton")]
            EatonEnum = 23,
            
            /// <summary>
            /// Enum EmmetEnum for "Emmet"
            /// </summary>
            [EnumMember(Value = "Emmet")]
            EmmetEnum = 24,
            
            /// <summary>
            /// Enum GeneseeEnum for "Genesee"
            /// </summary>
            [EnumMember(Value = "Genesee")]
            GeneseeEnum = 25,
            
            /// <summary>
            /// Enum GladwinEnum for "Gladwin"
            /// </summary>
            [EnumMember(Value = "Gladwin")]
            GladwinEnum = 26,
            
            /// <summary>
            /// Enum GogebicEnum for "Gogebic"
            /// </summary>
            [EnumMember(Value = "Gogebic")]
            GogebicEnum = 27,
            
            /// <summary>
            /// Enum GrandTraverseEnum for "Grand Traverse"
            /// </summary>
            [EnumMember(Value = "Grand Traverse")]
            GrandTraverseEnum = 28,
            
            /// <summary>
            /// Enum GratiotEnum for "Gratiot"
            /// </summary>
            [EnumMember(Value = "Gratiot")]
            GratiotEnum = 29,
            
            /// <summary>
            /// Enum HillsdaleEnum for "Hillsdale"
            /// </summary>
            [EnumMember(Value = "Hillsdale")]
            HillsdaleEnum = 30,
            
            /// <summary>
            /// Enum HoughtonEnum for "Houghton"
            /// </summary>
            [EnumMember(Value = "Houghton")]
            HoughtonEnum = 31,
            
            /// <summary>
            /// Enum HuronEnum for "Huron"
            /// </summary>
            [EnumMember(Value = "Huron")]
            HuronEnum = 32,
            
            /// <summary>
            /// Enum InghamEnum for "Ingham"
            /// </summary>
            [EnumMember(Value = "Ingham")]
            InghamEnum = 33,
            
            /// <summary>
            /// Enum IoniaEnum for "Ionia"
            /// </summary>
            [EnumMember(Value = "Ionia")]
            IoniaEnum = 34,
            
            /// <summary>
            /// Enum IoscoEnum for "Iosco"
            /// </summary>
            [EnumMember(Value = "Iosco")]
            IoscoEnum = 35,
            
            /// <summary>
            /// Enum IronEnum for "Iron"
            /// </summary>
            [EnumMember(Value = "Iron")]
            IronEnum = 36,
            
            /// <summary>
            /// Enum IsabellaEnum for "Isabella"
            /// </summary>
            [EnumMember(Value = "Isabella")]
            IsabellaEnum = 37,
            
            /// <summary>
            /// Enum JacksonEnum for "Jackson"
            /// </summary>
            [EnumMember(Value = "Jackson")]
            JacksonEnum = 38,
            
            /// <summary>
            /// Enum KalamazooEnum for "Kalamazoo"
            /// </summary>
            [EnumMember(Value = "Kalamazoo")]
            KalamazooEnum = 39,
            
            /// <summary>
            /// Enum KalkaskaEnum for "Kalkaska"
            /// </summary>
            [EnumMember(Value = "Kalkaska")]
            KalkaskaEnum = 40,
            
            /// <summary>
            /// Enum KentEnum for "Kent"
            /// </summary>
            [EnumMember(Value = "Kent")]
            KentEnum = 41,
            
            /// <summary>
            /// Enum KeweenawEnum for "Keweenaw"
            /// </summary>
            [EnumMember(Value = "Keweenaw")]
            KeweenawEnum = 42,
            
            /// <summary>
            /// Enum LakeEnum for "Lake"
            /// </summary>
            [EnumMember(Value = "Lake")]
            LakeEnum = 43,
            
            /// <summary>
            /// Enum LapeerEnum for "Lapeer"
            /// </summary>
            [EnumMember(Value = "Lapeer")]
            LapeerEnum = 44,
            
            /// <summary>
            /// Enum LeelanauEnum for "Leelanau"
            /// </summary>
            [EnumMember(Value = "Leelanau")]
            LeelanauEnum = 45,
            
            /// <summary>
            /// Enum LenaweeEnum for "Lenawee"
            /// </summary>
            [EnumMember(Value = "Lenawee")]
            LenaweeEnum = 46,
            
            /// <summary>
            /// Enum LivingstonEnum for "Livingston"
            /// </summary>
            [EnumMember(Value = "Livingston")]
            LivingstonEnum = 47,
            
            /// <summary>
            /// Enum LuceEnum for "Luce"
            /// </summary>
            [EnumMember(Value = "Luce")]
            LuceEnum = 48,
            
            /// <summary>
            /// Enum MackinacEnum for "Mackinac"
            /// </summary>
            [EnumMember(Value = "Mackinac")]
            MackinacEnum = 49,
            
            /// <summary>
            /// Enum MacombEnum for "Macomb"
            /// </summary>
            [EnumMember(Value = "Macomb")]
            MacombEnum = 50,
            
            /// <summary>
            /// Enum ManisteeEnum for "Manistee"
            /// </summary>
            [EnumMember(Value = "Manistee")]
            ManisteeEnum = 51,
            
            /// <summary>
            /// Enum MarquetteEnum for "Marquette"
            /// </summary>
            [EnumMember(Value = "Marquette")]
            MarquetteEnum = 52,
            
            /// <summary>
            /// Enum MasonEnum for "Mason"
            /// </summary>
            [EnumMember(Value = "Mason")]
            MasonEnum = 53,
            
            /// <summary>
            /// Enum MecostaEnum for "Mecosta"
            /// </summary>
            [EnumMember(Value = "Mecosta")]
            MecostaEnum = 54,
            
            /// <summary>
            /// Enum MenomineeEnum for "Menominee"
            /// </summary>
            [EnumMember(Value = "Menominee")]
            MenomineeEnum = 55,
            
            /// <summary>
            /// Enum MidlandEnum for "Midland"
            /// </summary>
            [EnumMember(Value = "Midland")]
            MidlandEnum = 56,
            
            /// <summary>
            /// Enum MissaukeeEnum for "Missaukee"
            /// </summary>
            [EnumMember(Value = "Missaukee")]
            MissaukeeEnum = 57,
            
            /// <summary>
            /// Enum MonroeEnum for "Monroe"
            /// </summary>
            [EnumMember(Value = "Monroe")]
            MonroeEnum = 58,
            
            /// <summary>
            /// Enum MontcalmEnum for "Montcalm"
            /// </summary>
            [EnumMember(Value = "Montcalm")]
            MontcalmEnum = 59,
            
            /// <summary>
            /// Enum MontmorencyEnum for "Montmorency"
            /// </summary>
            [EnumMember(Value = "Montmorency")]
            MontmorencyEnum = 60,
            
            /// <summary>
            /// Enum MuskegonEnum for "Muskegon"
            /// </summary>
            [EnumMember(Value = "Muskegon")]
            MuskegonEnum = 61,
            
            /// <summary>
            /// Enum NewaygoEnum for "Newaygo"
            /// </summary>
            [EnumMember(Value = "Newaygo")]
            NewaygoEnum = 62,
            
            /// <summary>
            /// Enum OaklandEnum for "Oakland"
            /// </summary>
            [EnumMember(Value = "Oakland")]
            OaklandEnum = 63,
            
            /// <summary>
            /// Enum OceanaEnum for "Oceana"
            /// </summary>
            [EnumMember(Value = "Oceana")]
            OceanaEnum = 64,
            
            /// <summary>
            /// Enum OgemawEnum for "Ogemaw"
            /// </summary>
            [EnumMember(Value = "Ogemaw")]
            OgemawEnum = 65,
            
            /// <summary>
            /// Enum OntonagonEnum for "Ontonagon"
            /// </summary>
            [EnumMember(Value = "Ontonagon")]
            OntonagonEnum = 66,
            
            /// <summary>
            /// Enum OsceolaEnum for "Osceola"
            /// </summary>
            [EnumMember(Value = "Osceola")]
            OsceolaEnum = 67,
            
            /// <summary>
            /// Enum OscodaEnum for "Oscoda"
            /// </summary>
            [EnumMember(Value = "Oscoda")]
            OscodaEnum = 68,
            
            /// <summary>
            /// Enum OtsegoEnum for "Otsego"
            /// </summary>
            [EnumMember(Value = "Otsego")]
            OtsegoEnum = 69,
            
            /// <summary>
            /// Enum OttawaEnum for "Ottawa"
            /// </summary>
            [EnumMember(Value = "Ottawa")]
            OttawaEnum = 70,
            
            /// <summary>
            /// Enum PresqueIsleEnum for "Presque Isle"
            /// </summary>
            [EnumMember(Value = "Presque Isle")]
            PresqueIsleEnum = 71,
            
            /// <summary>
            /// Enum RoscommonEnum for "Roscommon"
            /// </summary>
            [EnumMember(Value = "Roscommon")]
            RoscommonEnum = 72,
            
            /// <summary>
            /// Enum SaginawEnum for "Saginaw"
            /// </summary>
            [EnumMember(Value = "Saginaw")]
            SaginawEnum = 73,
            
            /// <summary>
            /// Enum StClairEnum for "St. Clair"
            /// </summary>
            [EnumMember(Value = "St. Clair")]
            StClairEnum = 74,
            
            /// <summary>
            /// Enum StJosephEnum for "St. Joseph"
            /// </summary>
            [EnumMember(Value = "St. Joseph")]
            StJosephEnum = 75,
            
            /// <summary>
            /// Enum SanilacEnum for "Sanilac"
            /// </summary>
            [EnumMember(Value = "Sanilac")]
            SanilacEnum = 76,
            
            /// <summary>
            /// Enum SchoolcraftEnum for "Schoolcraft"
            /// </summary>
            [EnumMember(Value = "Schoolcraft")]
            SchoolcraftEnum = 77,
            
            /// <summary>
            /// Enum ShiawasseeEnum for "Shiawassee"
            /// </summary>
            [EnumMember(Value = "Shiawassee")]
            ShiawasseeEnum = 78,
            
            /// <summary>
            /// Enum TuscolaEnum for "Tuscola"
            /// </summary>
            [EnumMember(Value = "Tuscola")]
            TuscolaEnum = 79,
            
            /// <summary>
            /// Enum VanBurenEnum for "Van Buren"
            /// </summary>
            [EnumMember(Value = "Van Buren")]
            VanBurenEnum = 80,
            
            /// <summary>
            /// Enum WashtenawEnum for "Washtenaw"
            /// </summary>
            [EnumMember(Value = "Washtenaw")]
            WashtenawEnum = 81,
            
            /// <summary>
            /// Enum WayneEnum for "Wayne"
            /// </summary>
            [EnumMember(Value = "Wayne")]
            WayneEnum = 82,
            
            /// <summary>
            /// Enum WexfordEnum for "Wexford"
            /// </summary>
            [EnumMember(Value = "Wexford")]
            WexfordEnum = 83
        }
}
