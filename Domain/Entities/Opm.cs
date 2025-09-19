using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Opm
    {
        public string CodOpm { get; set; }
        public string Descricao { get; set; }
        public string OPmPai { get; set; }
        public Opm()
        {
            
        }

        public Opm(string codopm, string descricao, string opmpai)
        {
            CodOpm = codopm;
            Descricao = descricao;
            OPmPai = opmpai;
        }


    }
}
