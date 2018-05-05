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
  public class Address {
    /// <summary>
    /// Gets or Sets AddressLine1
    /// </summary>
    [DataMember(Name="addressLine1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressLine1")]
    public string AddressLine1 { get; set; }

    /// <summary>
    /// Gets or Sets AddressLine2
    /// </summary>
    [DataMember(Name="addressLine2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressLine2")]
    public string AddressLine2 { get; set; }

    /// <summary>
    /// Gets or Sets City
    /// </summary>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// Gets or Sets StateOrProvence
    /// </summary>
    [DataMember(Name="stateOrProvence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stateOrProvence")]
    public string StateOrProvence { get; set; }

    /// <summary>
    /// Gets or Sets County
    /// </summary>
    [DataMember(Name="county", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "county")]
    public CountyMI County { get; set; }

    /// <summary>
    /// Gets or Sets Country
    /// </summary>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

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
      sb.Append("class Address {\n");
      sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
      sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  StateOrProvence: ").Append(StateOrProvence).Append("\n");
      sb.Append("  County: ").Append(County).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
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
