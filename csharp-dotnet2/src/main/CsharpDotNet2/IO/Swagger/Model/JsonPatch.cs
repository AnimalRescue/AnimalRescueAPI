using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Given the limitations of the Swagger 2.0 specification, this structure acts as a compromise that provides all fields required for any of the enumerated patch types.  They will be used as defined in RFC 6920.  In many cases, some of the fields will be unused.  It is the responsibility of the API service to access and process only those properties that are appropriate for the operation type specified. These are the field combinations are required by each of the enumerated values - add/path/value, remove/path, copy/fromPath/path, move/fromPath/path, delete/path, replace/path/value, test/path/value.
  /// </summary>
  [DataContract]
  public class JsonPatch : List<JsonPatchInner> {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JsonPatch {\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
