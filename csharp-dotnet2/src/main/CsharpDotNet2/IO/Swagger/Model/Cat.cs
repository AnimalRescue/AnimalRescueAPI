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
  public class Cat {
    /// <summary>
    /// Gets or Sets Animal
    /// </summary>
    [DataMember(Name="animal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "animal")]
    public AnimalInfo Animal { get; set; }

    /// <summary>
    /// Gets or Sets _Cat
    /// </summary>
    [DataMember(Name="cat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cat")]
    public CatInfo _Cat { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Cat {\n");
      sb.Append("  Animal: ").Append(Animal).Append("\n");
      sb.Append("  _Cat: ").Append(_Cat).Append("\n");
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
