using Application.DTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.Extensions
{
    internal static class PolicialExtension
    {
        public static PolicialDto toDto(this Policial policial)
        {
            return new PolicialDto
            { 
                Re = policial.Re,
                Nome = policial.Nome,
                Cpf = policial.Cpf,
                Opm = policial.toDto().Opm 
            };
        }

        public static PolicialDto toDtoMedalhas(this Policial policial)
        {
            return new PolicialDto
            {
                Re = policial.Re,
                Nome = policial.Nome,
                Cpf = policial.Cpf,
                Opm = policial.toDto().Opm,
                Medalhas = policial.toDto().Medalhas
            };
        }
    }
}
