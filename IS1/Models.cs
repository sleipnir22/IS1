using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace IS1
{
    //Представление данных из JSON в объектном виде
    public class Model
    {
        //Название модели
        public string name { get; set; }
        //Камера в мп
        public int camera { get; set; }
        //энергоемкость батареи
        public int battery { get; set; }
        //класс процессора
        [JsonConverter(typeof(StringEnumConverter))]
        public CPUtype cpu { get; set; }
        //объем накопителя смартфона
        public int drive { get; set; }
        //объем оперативной памяти
        public int ram { get; set; }
        //цена смартфона
        public int price { get; set; }
    }
    public struct ListModel
    {
        public List<Model> models { get; set; }
    }
    public enum CPUtype
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
        F,
        NoMatter
    }
}

