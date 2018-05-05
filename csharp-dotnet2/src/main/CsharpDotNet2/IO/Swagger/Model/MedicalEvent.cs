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
  public class MedicalEvent {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public MedicalEventId Id { get; set; }

    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public DateTime? Timestamp { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public MedicalEventType Type { get; set; }

    /// <summary>
    /// Gets or Sets SupportingData
    /// </summary>
    [DataMember(Name="supportingData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supportingData")]
    public SupportingMedicalDataId SupportingData { get; set; }

    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public List<NoteId> Notes { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [DataMember(Name="createdBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdBy")]
    public ContactId CreatedBy { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MedicalEvent {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  SupportingData: ").Append(SupportingData).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
