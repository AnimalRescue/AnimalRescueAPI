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
  public class Contact {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public ContactId Id { get; set; }

    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or Sets MiddleName
    /// </summary>
    [DataMember(Name="middleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "middleName")]
    public string MiddleName { get; set; }

    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or Sets Addresses
    /// </summary>
    [DataMember(Name="addresses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addresses")]
    public List<Address> Addresses { get; set; }

    /// <summary>
    /// Gets or Sets Phones
    /// </summary>
    [DataMember(Name="phones", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phones")]
    public List<PhoneNumber> Phones { get; set; }

    /// <summary>
    /// Gets or Sets Emails
    /// </summary>
    [DataMember(Name="emails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emails")]
    public List<EmailAddress> Emails { get; set; }

    /// <summary>
    /// Gets or Sets DateOfBirth
    /// </summary>
    [DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateOfBirth")]
    public DateTime? DateOfBirth { get; set; }

    /// <summary>
    /// Gets or Sets DriversLicense
    /// </summary>
    [DataMember(Name="driversLicense", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "driversLicense")]
    public string DriversLicense { get; set; }

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
      sb.Append("class Contact {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Addresses: ").Append(Addresses).Append("\n");
      sb.Append("  Phones: ").Append(Phones).Append("\n");
      sb.Append("  Emails: ").Append(Emails).Append("\n");
      sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
      sb.Append("  DriversLicense: ").Append(DriversLicense).Append("\n");
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
