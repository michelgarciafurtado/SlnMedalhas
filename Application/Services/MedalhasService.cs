using Application.DTO;
using Application.Extensions;
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
        public MedalhasService(IMedalhaRepository repository) {
            _repository = repository;

        }
        public async Task<MedalhaDto> Create(MedalhaDto medalha)
        {
            var me = await _repository.Create(medalha.fromDto());
            return me.toDto();
        }

        public async Task<IEnumerable<MedalhaDto>> GetAll()
        {
            var medalhas = await _repository.GetAll();
            List<MedalhaDto> listMedalhas = new List<MedalhaDto>();
            foreach (var item in medalhas)
            {
                listMedalhas.Add(item.toDto());
            }
            return listMedalhas;
        }

        public async Task<MedalhaDto> GetMedalha(int id)
        {
            var medalha = await _repository.GetMedalha(id);
            return medalha.toDto();
        }

        public async Task<IEnumerable<MedalhaDto>> GetMedalhasPolicial(string re)
        {
            var medalhas = await _repository.GetMedalhasPolicial(re);
            List<MedalhaDto> listMedalhas = new List<MedalhaDto>();
            foreach(var medalha in medalhas)
            {
                listMedalhas.Add(medalha.toDto());
            }

            return listMedalhas;
        }

        public async Task<MedalhaDto> Update(MedalhaDto medalha)
        {
            var me = await _repository.Update(medalha.fromDto());
            return me.toDto();
        }
    }
}
