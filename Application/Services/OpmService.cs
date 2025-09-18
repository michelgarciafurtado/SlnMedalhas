using Application.DTO;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class OpmService : IOpmService
    {
        private readonly IOpmRepository _repository;

        public OpmService(IOpmRepository repository)
        {
            _repository = repository;
        }

        public Task<OpmDto> Create(OpmDto opm)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OpmDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OpmDto> GetOpm(string codOpm)
        {
            throw new NotImplementedException();
        }

        public Task<OpmDto> Update(OpmDto opm)
        {
            throw new NotImplementedException();
        }
    }
}
