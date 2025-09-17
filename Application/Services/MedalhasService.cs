using Application.DTO;
using Application.Interfaces;
using Data.Repositories;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class MedalhasService : IMedalhaService
    {
        private readonly IMedalhaRepository _repository;
        public MedalhasService(MedalhaRepository repository) {
            _repository = repository;

        }
        public Task<MedalhaDto> Create(MedalhaDto medalha)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MedalhaDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<MedalhaDto> GetMedalha(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MedalhaDto> Update(MedalhaDto medalha)
        {
            throw new NotImplementedException();
        }
    }
}
