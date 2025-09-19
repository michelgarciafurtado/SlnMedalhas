using Application.DTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
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
                NomeMedalha = medalha.NomeMedalha,
                TipoMedalha = (int)medalha.TipoMedalha,
                DescricaoMedalha = medalha.TipoMedalha.ToString(),
                DataConcessao =  medalha.DataConcessao.ToString(),
                NBolConcessao = medalha.NBolConcessao,
                Re = medalha.Re,
                DataCassacao = medalha.DataCassacao.ToString(),
                NBolCassacao = medalha.NBolCassacao
            };
        }

        public static Medalha fromDto(this MedalhaDto medalhadto)
        {
            return new Medalha
            (
                medalhadto.NomeMedalha,
                medalhadto.TipoMedalha == 0 ? Domain.Enuns.TipoMedalhaEnum.Medalha : medalhadto.TipoMedalha == 1 ? Domain.Enuns.TipoMedalhaEnum.Láurea : Domain.Enuns.TipoMedalhaEnum.Condecoração,
                DateTime.Parse(medalhadto.DataConcessao, new CultureInfo("pt-BR")),
                medalhadto.NBolConcessao,
                medalhadto.Re
            );
        }

    }
}
