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
  public class Litter {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public LitterId Id { get; set; }

    /// <summary>
    /// Gets or Sets IsMotherIncluded
    /// </summary>
    [DataMember(Name="isMotherIncluded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isMotherIncluded")]
    public bool? IsMotherIncluded { get; set; }

    /// <summary>
    /// Gets or Sets Mother
    /// </summary>
    [DataMember(Name="mother", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mother")]
    public AnimalId Mother { get; set; }

    /// <summary>
    /// Gets or Sets Littermates
    /// </summary>
    [DataMember(Name="littermates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "littermates")]
    public List<AnimalId> Littermates { get; set; }

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
      sb.Append("class Litter {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IsMotherIncluded: ").Append(IsMotherIncluded).Append("\n");
      sb.Append("  Mother: ").Append(Mother).Append("\n");
      sb.Append("  Littermates: ").Append(Littermates).Append("\n");
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
