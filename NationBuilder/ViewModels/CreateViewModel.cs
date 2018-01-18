using System;
using System.Collections.Generic;
using System.Linq;

namespace NationBuilder.ViewModels
{ 
    public class CreateViewModel
    {
        
        public string Name { get; set; }
        public int GovVal { get; set; }
        public int EconId { get; set; }
        public int SpeciesId { get; set; }
        public int GeoId { get; set; }
        public static Dictionary<int, string> Governments = new Dictionary<int, string>()
            {
                { 5, "Anarchy"},
                { 3, "Oligarchy"},
                { 10, "Matriarchy"},
                { 4, "Patriarchy"},
                { 7, "Democracy"},
                { 8, "Piracy"}
            };

        //public static List<Object> Governments = new List<object> {
        //    new {
        //        Value = 3,
        //        Name = "Anarchy"
        //    },
        //    new {
        //        Value = 3,
        //        Name = "Oligarchy"
        //    },
        //    new {
        //        Value = 10,
        //        Name = "Matriarchy"
        //    },
        //    new {
        //        Value = 4,
        //        Name = "Patriarchy"
        //    },
        //    new {
        //        Value = 7,
        //        Name = "Democracy"
        //    },
        //    new {
        //        Value = 8,
        //        Name = "Piracy"
        //    }
        //};



    }
}
