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
  public class DateRange {
    /// <summary>
    /// Gets or Sets StartYear
    /// </summary>
    [DataMember(Name="startYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startYear")]
    public YearSelect StartYear { get; set; }

    /// <summary>
    /// Gets or Sets StartMonth
    /// </summary>
    [DataMember(Name="startMonth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startMonth")]
    public MonthSelect StartMonth { get; set; }

    /// <summary>
    /// Gets or Sets StartDayOfMonth
    /// </summary>
    [DataMember(Name="startDayOfMonth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDayOfMonth")]
    public DayOfMonthSelect StartDayOfMonth { get; set; }

    /// <summary>
    /// Gets or Sets EndYear
    /// </summary>
    [DataMember(Name="endYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endYear")]
    public YearSelect EndYear { get; set; }

    /// <summary>
    /// Gets or Sets EndMonth
    /// </summary>
    [DataMember(Name="endMonth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endMonth")]
    public MonthSelect EndMonth { get; set; }

    /// <summary>
    /// Gets or Sets EndDayOfMonth
    /// </summary>
    [DataMember(Name="endDayOfMonth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDayOfMonth")]
    public DayOfMonthSelect EndDayOfMonth { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DateRange {\n");
      sb.Append("  StartYear: ").Append(StartYear).Append("\n");
      sb.Append("  StartMonth: ").Append(StartMonth).Append("\n");
      sb.Append("  StartDayOfMonth: ").Append(StartDayOfMonth).Append("\n");
      sb.Append("  EndYear: ").Append(EndYear).Append("\n");
      sb.Append("  EndMonth: ").Append(EndMonth).Append("\n");
      sb.Append("  EndDayOfMonth: ").Append(EndDayOfMonth).Append("\n");
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
