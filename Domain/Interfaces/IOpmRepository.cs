using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IOpmRepository
    {
        public Task<Opm> Create(Opm opm);
        public Task<Opm> Update(Opm opm);
        public Task<Opm> GetOpm(string codOpm);
        public Task<IEnumerable<Opm>> GetAll();
    }
}
