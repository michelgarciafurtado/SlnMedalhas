using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Policial
    {
        public  string Re { get; set; }
        public string Nome { get; set; }
        public  string PostoGrad { get; set; }
        public  string Cpf { get; set; }

        public string CodOpm { get; set; }
        public Opm Opm { get; set; }
        public List<Medalha> medalhas { get; set; }

        public Policial(string re, string nome, string postograd, string cpf, Opm opm, string codopm)
        {
            Re = re;
            Nome = nome;
            PostoGrad = postograd;
            Cpf = cpf;
            Opm = opm;
            CodOpm = codopm;
        }
    }
}
