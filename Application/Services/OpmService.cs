using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class OpmService : IOpmRepository
    {
        private readonly IOpmRepository _repository;

        public OpmService(IOpmRepository repository)
        {
            _repository = repository;
        }
        public Task<Opm> Create(Opm opm)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Opm>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Opm> GetOpm(string codOpm)
        {
            throw new NotImplementedException();
        }

        public Task<Opm> Update(Opm opm)
        {
            throw new NotImplementedException();
        }
    }
}
