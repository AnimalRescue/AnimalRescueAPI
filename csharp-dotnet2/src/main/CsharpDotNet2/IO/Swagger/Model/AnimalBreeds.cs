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
  public class AnimalBreeds {
    /// <summary>
    /// Gets or Sets CatBreeds
    /// </summary>
    [DataMember(Name="catBreeds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "catBreeds")]
    public CatBreeds CatBreeds { get; set; }

    /// <summary>
    /// Gets or Sets DogBreeds
    /// </summary>
    [DataMember(Name="dogBreeds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dogBreeds")]
    public DogBreeds DogBreeds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AnimalBreeds {\n");
      sb.Append("  CatBreeds: ").Append(CatBreeds).Append("\n");
      sb.Append("  DogBreeds: ").Append(DogBreeds).Append("\n");
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
