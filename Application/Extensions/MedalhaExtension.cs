using Application.DTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Extensions
{
    internal static class MedalhaExtension
    {
        public static MedalhaDto toDto(this Medalha medalha)
        {
            return new MedalhaDto
            {
                IdMedalha = medalha.IdMedalha,
                TipoMedalha = medalha.TipoMedalha.ToString(),
                DataConcessao =  medalha.DataConcessao.ToString(),
                NBolConcessao = medalha.NBolConcessao,
                Re = medalha.Re,
                DataCassacao = medalha.DataCassacao.ToString(),
                NBolCassacao = medalha.NBolCassacao
            };
        }
    }
}
