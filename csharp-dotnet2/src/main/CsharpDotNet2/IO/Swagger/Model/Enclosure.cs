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
  public class Enclosure {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public EnclosureId Id { get; set; }

    /// <summary>
    /// Gets or Sets Size
    /// </summary>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public decimal? Size { get; set; }

    /// <summary>
    /// Gets or Sets UnitOfAreaMeasure
    /// </summary>
    [DataMember(Name="unitOfAreaMeasure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitOfAreaMeasure")]
    public string UnitOfAreaMeasure { get; set; }

    /// <summary>
    /// Gets or Sets HeightInFeet
    /// </summary>
    [DataMember(Name="heightInFeet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "heightInFeet")]
    public decimal? HeightInFeet { get; set; }

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
      sb.Append("class Enclosure {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
      sb.Append("  UnitOfAreaMeasure: ").Append(UnitOfAreaMeasure).Append("\n");
      sb.Append("  HeightInFeet: ").Append(HeightInFeet).Append("\n");
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
