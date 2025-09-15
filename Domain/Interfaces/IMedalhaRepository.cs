using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IMedalhaRepository
    {
        public Task<Medalha> Create(Medalha medalha);
        public Task<Medalha> Update(Medalha medalha); 
        public Task<Medalha> GetMedalha(int id);
        public Task<IEnumerable<Medalha>> GetAll();
    }
}
