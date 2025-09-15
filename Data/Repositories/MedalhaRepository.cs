using Data.Context;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class MedalhaRepository : IMedalhaRepository
    {
        private static ApplicationDbContext _context;

        public MedalhaRepository(ApplicationDbContext context)
        {
            _context = context; 
        }

        public async Task<Medalha> Create(Medalha medalha)
        {
            _context.AddAsync(medalha);
            await _context.SaveChangesAsync();
            return medalha;
        }

        public async Task<IEnumerable<Medalha>> GetAll()
        {
            return await _context.Medalhas.ToListAsync();
        }

        public async Task<Medalha> GetMedalha(int id)
        {
            return await _context.Medalhas.FindAsync(id);
        }

        public async Task<Medalha> Update(Medalha medalha)
        {
            _context.Update(medalha);
            await _context.SaveChangesAsync();
            return medalha;
        }
    }
}
