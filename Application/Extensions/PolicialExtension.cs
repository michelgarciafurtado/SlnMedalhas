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
                PostoGrad = policial.PostoGrad,
                Cpf = policial.Cpf,
                CodOpm = policial.CodOpm,
                Opm = policial.Opm.toDto(),
            };
        }

        public static PolicialDto toDtoMedalhas(this Policial policial)
        {
            var medalhas = policial.medalhas;
            List<MedalhaDto> listmedalhas = new List<MedalhaDto>();
            foreach (var item in medalhas)
            {
                listmedalhas.Add(item.toDto());
            }
            return new PolicialDto
            {
                Re = policial.Re,
                Nome = policial.Nome,
                PostoGrad = policial.PostoGrad,
                Cpf = policial.Cpf,
                Opm = policial.toDto().Opm,
                Medalhas = listmedalhas
            };
        }

        internal static Policial FromDto(this PolicialDto pol)
        {
            return new Policial
            (
               pol.Re,
               pol.Nome,
               pol.PostoGrad,
               pol.Cpf,
               pol.Opm.CodOpm
            );
        }
    }
}
