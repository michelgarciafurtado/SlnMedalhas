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
    internal static class OpmExtensions
    {
        public static OpmDto toDto(this Opm opm)
        {
            return new OpmDto
            {
                CodOpm = opm.CodOpm,
                Descricao = opm.Descricao,
                OPmPai = opm.OPmPai
            };

        }

        public static Opm fromDto(this OpmDto opm)
        {
            return new Opm
            (
                opm.CodOpm,
                opm.Descricao,
                opm.OPmPai
            );
        }
    }
}
