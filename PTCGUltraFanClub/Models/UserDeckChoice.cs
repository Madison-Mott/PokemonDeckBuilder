using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTCGUltraFanClub.Models
{
    public class UserDeckChoice
    {
            [Key]
            public int ID { get; set; }
            public string DeckChoice { get; set; }
    }
}
