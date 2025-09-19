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
            bool evalido = true;
            // Remove caracteres não numéricos
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Verifica se tem 11 dígitos
            if (cpf.Length != 11)
                evalido = false;

            // Verifica se todos os dígitos são iguais
            if (cpf.All(c => c == cpf[0]))
                evalido = false;

            // Calcula primeiro dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * (10 - i);

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            // Verifica primeiro dígito
            if (int.Parse(cpf[9].ToString()) != digito1)
                evalido = false;

            // Calcula segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf[i].ToString()) * (11 - i);

            resto = soma % 11;
            // Verifica segundo dígito
            int digito2 = resto < 2 ? 0 : 11 - resto;
            if (int.Parse(cpf[10].ToString()) != digito2)
                evalido = false;

            return evalido;
        }
    }
    
}
