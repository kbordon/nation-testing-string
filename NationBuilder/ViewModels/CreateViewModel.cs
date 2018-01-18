using System;
using System.Collections.Generic;

namespace NationBuilder.ViewModels
{
    public class CreateViewModel
    {
        public string Name { get; set; }
        public int GovId { get; set; }
        public int EconId { get; set; }
        public int SpeciesId { get; set; }
        public int GeoId { get; set; }

        public static IEnumerable<Object> Governments = new List<object> {
            new {
                GovId = 1,
                Name = "Oligarchy"
            },
            new {
                ColorId = 2,
                Name = "Monarchy"
            }
        };

    }
}
