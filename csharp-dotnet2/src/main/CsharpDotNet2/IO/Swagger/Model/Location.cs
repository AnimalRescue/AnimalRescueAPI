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
  public class Location {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public LocationId Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public Address Address { get; set; }

    /// <summary>
    /// Gets or Sets Buildings
    /// </summary>
    [DataMember(Name="buildings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buildings")]
    public List<BuildingId> Buildings { get; set; }

    /// <summary>
    /// Gets or Sets Enclosures
    /// </summary>
    [DataMember(Name="enclosures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enclosures")]
    public List<EnclosureId> Enclosures { get; set; }

    /// <summary>
    /// Gets or Sets Kennels
    /// </summary>
    [DataMember(Name="kennels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kennels")]
    public List<KennelId> Kennels { get; set; }

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
      sb.Append("class Location {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Buildings: ").Append(Buildings).Append("\n");
      sb.Append("  Enclosures: ").Append(Enclosures).Append("\n");
      sb.Append("  Kennels: ").Append(Kennels).Append("\n");
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
