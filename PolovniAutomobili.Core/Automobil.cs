using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolovniAutomobili.Core
{
    public class Automobil
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(255)]
        public string Description { get; set; }
        public Enums.GorivoVrsta Gorivo { get; set; }
    }
}
