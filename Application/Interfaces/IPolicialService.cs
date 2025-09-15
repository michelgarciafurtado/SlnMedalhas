using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPolicialService
    {
        public Task<Policial> Create(Policial pol);
        public Task<Policial> Update(Policial pol);
        public Task<Policial> GetPolicial(string re);
        public Task<IEnumerable<Policial>> GetAll();
    }
}
