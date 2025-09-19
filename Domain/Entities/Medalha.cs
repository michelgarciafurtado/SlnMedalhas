using Domain.Enuns;

namespace Domain.Entities
{
    public class Medalha
    {
        public int IdMedalha { get; set; }
        public string NomeMedalha { get; set; }
        public TipoMedalhaEnum TipoMedalha { get; set;}
        public DateTime DataConcessao { get; set; }
        public string NBolConcessao { get; set; }
        public string Re {  get; set; }
        public Policial Policial {  get; set; }
        public DateTime? DataCassacao { get; set; }
        public string? NBolCassacao { get; set; }

        public Medalha()
        {
            
        }
        public Medalha(string nomemedalha, TipoMedalhaEnum tipomedalha, DateTime dataconcessao, string nbolconcessao, string re)
        {
            NomeMedalha = nomemedalha;
            TipoMedalha = tipomedalha;
            DataConcessao = dataconcessao;
            NBolConcessao = nbolconcessao;
            Re = re;
        }
        public Medalha(int idmedalha, string nomemedalha, TipoMedalhaEnum tipomedalha, DateTime dataconcessao, string nbolconcessao, string re, Policial policial)
        {
            IdMedalha = idmedalha;
            NomeMedalha = nomemedalha;
            TipoMedalha = tipomedalha;
            DataConcessao = dataconcessao;
            NBolConcessao = nbolconcessao;
            Policial = policial;
        }
    }
}
