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
  public class Kennel {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public KennelId Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Species
    /// </summary>
    [DataMember(Name="species", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "species")]
    public AnimalType Species { get; set; }

    /// <summary>
    /// Gets or Sets MaxOccupancy
    /// </summary>
    [DataMember(Name="maxOccupancy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxOccupancy")]
    public int? MaxOccupancy { get; set; }

    /// <summary>
    /// Gets or Sets Animals
    /// </summary>
    [DataMember(Name="animals", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "animals")]
    public List<AnimalId> Animals { get; set; }

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
      sb.Append("class Kennel {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Species: ").Append(Species).Append("\n");
      sb.Append("  MaxOccupancy: ").Append(MaxOccupancy).Append("\n");
      sb.Append("  Animals: ").Append(Animals).Append("\n");
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
