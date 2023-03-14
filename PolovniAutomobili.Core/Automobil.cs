using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolovniAutomobili.Core
{
    public class Automobil
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Enums.GorivoVrsta Gorivo { get; set; }
    }
}
