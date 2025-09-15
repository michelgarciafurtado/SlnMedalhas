using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class PolicialDto
    {
        public string Re { get; set; }
        public string Nome { get; set; }
        public string PostoGrad { get; set; }
        public string Cpf { get; set; }
        public OpmDto Opm { get; set; }
        public List<MedalhaDto> Medalhas { get; set; }
    }
}
