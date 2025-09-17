using Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IOpmService
    {
        public Task<OpmDto> Create(OpmDto opm);
        public Task<OpmDto> Update(OpmDto opm);
        public Task<OpmDto> GetOpm(string codOpm);
        public Task<IEnumerable<OpmDto>> GetAll();
    }
}
