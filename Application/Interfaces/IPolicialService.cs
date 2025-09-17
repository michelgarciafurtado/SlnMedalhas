using Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPolicialService
    {
        public Task<PolicialDto> Create(PolicialDto pol);
        public Task<PolicialDto> Update(PolicialDto pol);
        public Task<PolicialDto> GetPolicial(string re);
        public Task<IEnumerable<PolicialDto>> GetAll();
    }
}
