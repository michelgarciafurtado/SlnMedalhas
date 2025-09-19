using Application.DTO;
using Application.Extensions;
using Application.Interfaces;
using Domain.Interfaces;

namespace Application.Services
{
    public class PolicialService : IPolicialService
    {
        private readonly IPolicialRepository _repository;
        private readonly IOpmRepository      _opmrepository;
        private readonly IMedalhaRepository  _medalhasrepository;
        public PolicialService(IPolicialRepository repository, IOpmRepository opmrepository, IMedalhaRepository medalharepository)
        {
            _repository = repository;
            _opmrepository = opmrepository;
            _medalhasrepository = medalharepository;
        }
        public async Task<PolicialDto> Create(PolicialDto pol)
        {
            var policial = await _repository.Create(pol.FromDto());
            var opm = await _opmrepository.GetOpm(policial.CodOpm);
            policial.Opm = opm;
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
            return policial.toDtoMedalhas();
        }

        public async Task<PolicialDto> Update(PolicialDto pol)
        {
            var policial = await _repository.Update(pol.FromDto());
            return policial.toDto();
        }
    }
}
