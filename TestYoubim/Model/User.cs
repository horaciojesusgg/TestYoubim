using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestYoubim.Model
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Column]
        public string UserName { get; set; }
        [Required]
        [Column]
        public string Name { get; set; }
        [Required]
        [Column]
        public string Email { get; set; }

        [Required]
        [Column]
        public string PlainPassword { get; set; }

        [Required]
        [Column]
        public byte[] PasswordHash { get; set; }
        [Required]
        [Column]
        public byte[] PasswordSalt { get; set; }
    }
}
