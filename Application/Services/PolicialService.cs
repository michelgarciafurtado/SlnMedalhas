using Application.DTO;
using Application.Extensions;
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
    public class PolicialService : IPolicialService
    {
        private readonly IPolicialRepository _repository;
        public PolicialService(IPolicialRepository repository)
        {
            _repository = repository;
        }
        public async Task<PolicialDto> Create(PolicialDto pol)
        {
            var policial = await _repository.Create(pol.FromDto());
            return policial.toDto();
        }
        public async Task<IEnumerable<PolicialDto>> GetAll()
        {
           var policiais = await _repository.GetAll();
            List<PolicialDto> policiaisdto = new List<PolicialDto>();
            foreach (var pol in policiais) {
                policiaisdto.Add(pol.toDto());
            }
            return policiaisdto;
        }
        public async Task<PolicialDto> GetPolicial(string re)
        {
            var policial = await _repository.GetPolicial(re);
            return policial.toDto();
        }

        public async Task<PolicialDto> Update(PolicialDto pol)
        {
            var policial = await _repository.Update(pol.FromDto());
            return policial.toDto();
        }
    }
}
