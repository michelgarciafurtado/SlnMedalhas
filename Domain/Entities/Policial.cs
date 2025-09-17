using Domain.Validation;
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
            DomainExceptionValidation.When(re.Length < 6, "Verifique o preenchimento do RE");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome),"Nome e obrigatorio");
            DomainExceptionValidation.When(cpf.Length < 11, "CPF deve ser informado com digito");
            DomainExceptionValidation.When(ValidaCpf.Validar(cpf), "Cpf informado e invalido");
            Re = re;
            Nome = nome;
            PostoGrad = postograd;
            Cpf = cpf;
            Opm = opm;
            CodOpm = codopm;
        }
    }
}
