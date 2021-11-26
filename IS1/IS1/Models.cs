using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace IS1
{
    internal class Model
    {
        public string name { get; set; }
        public int camera { get; set; }
        public int battery { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CPUtype cpu { get; set; }
        public int drive { get; set; }
        public int ram { get; set; }
        public int price { get; set; }
    }
    internal struct ListModel
    {
        public List<Model> models { get; set; }
    }
    internal enum CPUtype
    {
        [EnumMember(Value = "A+")]
        A,
        [EnumMember(Value = "B")]
        B,
        [EnumMember(Value = "C")]
        C,
        [EnumMember(Value = "D")]
        D,
        [EnumMember(Value = "F")]
        F
    }
}
