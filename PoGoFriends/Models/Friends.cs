using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoGoFriends.Models
{
    public class Friends
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nickname { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        [DisplayName("Trainer Code")]
        public int Code { get; set; }
     
        [DisplayName("Leave a note")]
        public string TextBox { get; set; }
    }
}
