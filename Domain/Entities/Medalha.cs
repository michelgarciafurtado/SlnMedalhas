using Domain.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Medalha
    {
        public string IdMedalha { get; set; }
        public string NomeMedalha { get; set; }
        public TipoMedalhaEnum TipoMedalha { get; set;}
        public DateTime DataConcessao { get; set; }
        public string NBolConcessao { get; set; }
        public string Re {  get; set; }
        public Policial Policial {  get; set; }
        public DateTime DataCassacao { get; set; }
        public string NBolCassacao { get; set; }

        public Medalha(string nomemedalha, TipoMedalhaEnum tipomedalha, DateTime dataconcessao, string nbolconcessao, string re, Policial policial)
        {
            NomeMedalha = nomemedalha;
            TipoMedalha = tipomedalha;
            DataConcessao = dataconcessao;
            NBolConcessao = nbolconcessao;
            Re = re;
            Policial = policial;
        }
    }
}
