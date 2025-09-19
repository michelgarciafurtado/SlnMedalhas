using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class MedalhaDto
    {
        public int IdMedalha { get; set; }
        public string NomeMedalha { get; set; }
        public int TipoMedalha { get; set; }
        public string DescricaoMedalha { get; set; }
        public string DataConcessao { get; set; }
        public string NBolConcessao { get; set; }
        public string Re { get; set; }
        public string DataCassacao { get; set; }
        public string NBolCassacao { get; set; }
    }
}
