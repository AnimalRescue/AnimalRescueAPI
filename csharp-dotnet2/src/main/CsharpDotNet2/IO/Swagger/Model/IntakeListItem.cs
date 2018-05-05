using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Item of IntakeList
  /// </summary>
  [DataContract]
  public class IntakeListItem {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public IntakeId Id { get; set; }

    /// <summary>
    /// Gets or Sets ParNumber
    /// </summary>
    [DataMember(Name="parNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parNumber")]
    public ParNumber ParNumber { get; set; }

    /// <summary>
    /// Gets or Sets DateOfIntake
    /// </summary>
    [DataMember(Name="dateOfIntake", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateOfIntake")]
    public DateTime? DateOfIntake { get; set; }

    /// <summary>
    /// Gets or Sets AnimalId
    /// </summary>
    [DataMember(Name="animalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "animalId")]
    public AnimalId AnimalId { get; set; }

    /// <summary>
    /// Gets or Sets AnimalName
    /// </summary>
    [DataMember(Name="animalName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "animalName")]
    public string AnimalName { get; set; }

    /// <summary>
    /// Gets or Sets IsInIsolation
    /// </summary>
    [DataMember(Name="isInIsolation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isInIsolation")]
    public bool? IsInIsolation { get; set; }

    /// <summary>
    /// Gets or Sets AdoptionStatus
    /// </summary>
    [DataMember(Name="adoptionStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adoptionStatus")]
    public string AdoptionStatus { get; set; }

    /// <summary>
    /// Gets or Sets KennelName
    /// </summary>
    [DataMember(Name="kennelName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kennelName")]
    public string KennelName { get; set; }

    /// <summary>
    /// Gets or Sets KennelId
    /// </summary>
    [DataMember(Name="kennelId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kennelId")]
    public KennelId KennelId { get; set; }

    /// <summary>
    /// Gets or Sets RoomName
    /// </summary>
    [DataMember(Name="roomName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roomName")]
    public string RoomName { get; set; }

    /// <summary>
    /// Gets or Sets RoomId
    /// </summary>
    [DataMember(Name="roomId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roomId")]
    public RoomId RoomId { get; set; }

    /// <summary>
    /// Gets or Sets BuildingName
    /// </summary>
    [DataMember(Name="buildingName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buildingName")]
    public string BuildingName { get; set; }

    /// <summary>
    /// Gets or Sets BuildingId
    /// </summary>
    [DataMember(Name="buildingId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buildingId")]
    public BuildingId BuildingId { get; set; }

    /// <summary>
    /// Gets or Sets LocationName
    /// </summary>
    [DataMember(Name="locationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locationName")]
    public string LocationName { get; set; }

    /// <summary>
    /// Gets or Sets LocationId
    /// </summary>
    [DataMember(Name="locationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locationId")]
    public LocationId LocationId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
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
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
