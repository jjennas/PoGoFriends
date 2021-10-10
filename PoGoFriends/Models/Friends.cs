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
        [StringLength(30, MinimumLength = 4)]
        public string Nickname { get; set; }
        [Required]
        public string Country { get; set; }
        [DisplayName("Trainer Code")]
        [Required]
        [RegularExpression("(^[0-9]{12}$)", ErrorMessage = "Trainer Code must be 12 digits and contain only numbers.")]
        public long Code { get; set; }

        [DisplayName("Leave a note")]
        public string TextBox { get; set; }
    }
}
