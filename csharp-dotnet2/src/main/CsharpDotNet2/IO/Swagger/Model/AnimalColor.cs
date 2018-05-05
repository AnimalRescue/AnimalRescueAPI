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
  public class AnimalColor {
    /// <summary>
    /// Gets or Sets CatColor
    /// </summary>
    [DataMember(Name="catColor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "catColor")]
    public CatColors CatColor { get; set; }

    /// <summary>
    /// Gets or Sets DogColor
    /// </summary>
    [DataMember(Name="dogColor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dogColor")]
    public DogColors DogColor { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AnimalColor {\n");
      sb.Append("  CatColor: ").Append(CatColor).Append("\n");
      sb.Append("  DogColor: ").Append(DogColor).Append("\n");
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
