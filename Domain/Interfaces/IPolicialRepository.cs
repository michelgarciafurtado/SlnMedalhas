using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IPolicialRepository
    {
        public Task<Policial> Create(Policial pol);
        public Task<Policial> Update(Policial pol);
        public Task<Policial> GetPolicial(string re);
        public Task<IEnumerable<Policial>> GetAll();
    }
}
