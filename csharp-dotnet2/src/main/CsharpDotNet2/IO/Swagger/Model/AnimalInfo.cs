using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class AnimalInfo {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public AnimalId Id { get; set; }

    /// <summary>
    /// Gets or Sets ParNumber
    /// </summary>
    [DataMember(Name="parNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parNumber")]
    public ParNumber ParNumber { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public AdoptionStatus Status { get; set; }

    /// <summary>
    /// Gets or Sets AnimalType
    /// </summary>
    [DataMember(Name="animalType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "animalType")]
    public AnimalType AnimalType { get; set; }

    /// <summary>
    /// Gets or Sets Gender
    /// </summary>
    [DataMember(Name="gender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gender")]
    public Gender Gender { get; set; }

    /// <summary>
    /// Gets or Sets AgeIsEstimated
    /// </summary>
    [DataMember(Name="ageIsEstimated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ageIsEstimated")]
    public bool? AgeIsEstimated { get; set; }

    /// <summary>
    /// Gets or Sets Age
    /// </summary>
    [DataMember(Name="age", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "age")]
    public string Age { get; set; }

    /// <summary>
    /// Gets or Sets DateOfBirth
    /// </summary>
    [DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateOfBirth")]
    public DateTime? DateOfBirth { get; set; }

    /// <summary>
    /// Gets or Sets IsPartOfLitter
    /// </summary>
    [DataMember(Name="isPartOfLitter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPartOfLitter")]
    public bool? IsPartOfLitter { get; set; }

    /// <summary>
    /// Gets or Sets LitterId
    /// </summary>
    [DataMember(Name="litterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "litterId")]
    public LitterId LitterId { get; set; }

    /// <summary>
    /// Gets or Sets MedicalHistoryId
    /// </summary>
    [DataMember(Name="medicalHistoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "medicalHistoryId")]
    public MedicalHistoryId MedicalHistoryId { get; set; }

    /// <summary>
    /// Gets or Sets KennelId
    /// </summary>
    [DataMember(Name="kennelId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kennelId")]
    public KennelId KennelId { get; set; }

    /// <summary>
    /// Gets or Sets Bio
    /// </summary>
    [DataMember(Name="bio", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bio")]
    public string Bio { get; set; }

    /// <summary>
    /// Gets or Sets Photos
    /// </summary>
    [DataMember(Name="photos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "photos")]
    public PhotoId Photos { get; set; }

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
      sb.Append("class AnimalInfo {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ParNumber: ").Append(ParNumber).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  AnimalType: ").Append(AnimalType).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  AgeIsEstimated: ").Append(AgeIsEstimated).Append("\n");
      sb.Append("  Age: ").Append(Age).Append("\n");
      sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
      sb.Append("  IsPartOfLitter: ").Append(IsPartOfLitter).Append("\n");
      sb.Append("  LitterId: ").Append(LitterId).Append("\n");
      sb.Append("  MedicalHistoryId: ").Append(MedicalHistoryId).Append("\n");
      sb.Append("  KennelId: ").Append(KennelId).Append("\n");
      sb.Append("  Bio: ").Append(Bio).Append("\n");
      sb.Append("  Photos: ").Append(Photos).Append("\n");
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
