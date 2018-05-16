using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PonyMaze.Common
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Direction
    {
        [EnumMember(Value = "north")]
        North = 1,

        [EnumMember(Value = "south")]
        South = 2,

        [EnumMember(Value = "east")]
        East = 4,

        [EnumMember(Value = "west")]
        West = 8
    }

}
