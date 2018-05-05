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
  public class PhoneNumber {
    /// <summary>
    /// Gets or Sets Number
    /// </summary>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public int? Number { get; set; }

    /// <summary>
    /// Gets or Sets PhoneType
    /// </summary>
    [DataMember(Name="phoneType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phoneType")]
    public PhoneNumberType PhoneType { get; set; }

    /// <summary>
    /// Gets or Sets PhonePurpose
    /// </summary>
    [DataMember(Name="phonePurpose", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phonePurpose")]
    public PhoneNumberPurpose PhonePurpose { get; set; }

    /// <summary>
    /// Gets or Sets NoteId
    /// </summary>
    [DataMember(Name="noteId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "noteId")]
    public NoteId NoteId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PhoneNumber {\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  PhoneType: ").Append(PhoneType).Append("\n");
      sb.Append("  PhonePurpose: ").Append(PhonePurpose).Append("\n");
      sb.Append("  NoteId: ").Append(NoteId).Append("\n");
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
