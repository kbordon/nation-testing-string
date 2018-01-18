using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NationBuilder.Models
{
    [Table("nations")]
    public class Nation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Government { get; set; }
        public int Economy { get; set; }
        public int Species { get; set; }
        public int Geography { get; set; }
        public virtual GameUser User { get; set; }

        public Nation()
        {
        }
    }
}
