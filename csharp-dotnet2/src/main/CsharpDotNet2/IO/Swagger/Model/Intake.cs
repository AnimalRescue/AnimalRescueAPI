using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Aggregate representing an animal being registered into the Rescue
  /// </summary>
  [DataContract]
  public class Intake {
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
    /// Gets or Sets AnimalInfoId
    /// </summary>
    [DataMember(Name="animalInfoId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "animalInfoId")]
    public AnimalId AnimalInfoId { get; set; }

    /// <summary>
    /// Gets or Sets DateOfIntake
    /// </summary>
    [DataMember(Name="dateOfIntake", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateOfIntake")]
    public DateTime? DateOfIntake { get; set; }

    /// <summary>
    /// Gets or Sets TypeOfIntake
    /// </summary>
    [DataMember(Name="typeOfIntake", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "typeOfIntake")]
    public IntakeType TypeOfIntake { get; set; }

    /// <summary>
    /// Gets or Sets SurrendingPartyId
    /// </summary>
    [DataMember(Name="surrendingPartyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "surrendingPartyId")]
    public ContactId SurrendingPartyId { get; set; }

    /// <summary>
    /// Gets or Sets TransferringShelterId
    /// </summary>
    [DataMember(Name="transferringShelterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transferringShelterId")]
    public OrganizationId TransferringShelterId { get; set; }

    /// <summary>
    /// Gets or Sets PlaceInIsolation
    /// </summary>
    [DataMember(Name="placeInIsolation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "placeInIsolation")]
    public bool? PlaceInIsolation { get; set; }

    /// <summary>
    /// Gets or Sets StaffId
    /// </summary>
    [DataMember(Name="staffId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "staffId")]
    public ContactId StaffId { get; set; }

    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public List<NoteId> Notes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Intake {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ParNumber: ").Append(ParNumber).Append("\n");
      sb.Append("  AnimalInfoId: ").Append(AnimalInfoId).Append("\n");
      sb.Append("  DateOfIntake: ").Append(DateOfIntake).Append("\n");
      sb.Append("  TypeOfIntake: ").Append(TypeOfIntake).Append("\n");
      sb.Append("  SurrendingPartyId: ").Append(SurrendingPartyId).Append("\n");
      sb.Append("  TransferringShelterId: ").Append(TransferringShelterId).Append("\n");
      sb.Append("  PlaceInIsolation: ").Append(PlaceInIsolation).Append("\n");
      sb.Append("  StaffId: ").Append(StaffId).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
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
