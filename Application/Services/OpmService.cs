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
    public class OpmService : IOpmService
    {
        IOpmRepository _repository;

        public OpmService(IOpmRepository repository)
        {
            _repository = repository;
        }

        public async Task<OpmDto> Create(OpmDto opm)
        {
            var entity = await _repository.Create(opm.fromDto());
            return entity.toDto();
        }

        public async Task<IEnumerable<OpmDto>> GetAll()
        {
            List<OpmDto> listaOpmDto = new List<OpmDto>();
            var Opms = await _repository.GetAll();
            foreach (var opm in Opms)
            {
                listaOpmDto.Add(opm.toDto());
            }
            return listaOpmDto;
        }

        public async Task<OpmDto> GetOpm(string codOpm)
        {
            var entity = await _repository.GetOpm(codOpm);
            return entity.toDto();
        }

        public async Task<OpmDto> Update(OpmDto opm)
        {
           var entity =  await _repository.Update(opm.fromDto());
            return entity.toDto() ;
        }
    }
}
