
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace TestYoubim.Model
{
    public class Node
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey(name: "userId")]
        [Column]
        public string IdUser { get; set; }
        [Required]
        [Column]
        public string Name { get; set; }
        [Required]
        [Column]
        public string VersionFile { get; set; }
    }
}
