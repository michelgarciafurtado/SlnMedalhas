using Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IMedalhaService
    {
        public Task<MedalhaDto> Create(MedalhaDto medalha);
        public Task<MedalhaDto> Update(MedalhaDto medalha);
        public Task<MedalhaDto> GetMedalha(int id);
        public Task<IEnumerable<MedalhaDto>> GetAll();
        public Task<IEnumerable<MedalhaDto>> GetMedalhasPolicial(string re);
    }
}
