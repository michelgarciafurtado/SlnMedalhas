using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PolicialService : IPolicialRepository
    {
        private readonly IPolicialRepository _repository;

        public PolicialService(IPolicialRepository repository)
        {
            _repository = repository;
        }
        public Task<Policial> Create(Policial pol)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Policial>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Policial> GetPolicial(string re)
        {
            throw new NotImplementedException();
        }

        public Task<Policial> Update(Policial pol)
        {
            throw new NotImplementedException();
        }
    }
}
