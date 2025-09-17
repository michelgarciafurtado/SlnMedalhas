using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validation
{
    public static class ValidaCpf
    {
        public static bool Validar(string cpf)
        {
            // Remove caracteres não numéricos
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Verifica se tem 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verifica se todos os dígitos são iguais
            if (cpf.Distinct().Count() == 1)
                return false;

            // Calcula primeiro dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * (10 - i);

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            // Verifica primeiro dígito
            if (int.Parse(cpf[9].ToString()) != digito1)
                return false;

            // Calcula segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf[i].ToString()) * (11 - i);

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            // Verifica segundo dígito
            return int.Parse(cpf[10].ToString()) == digito2;
        }
    }
    
}
