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
    public class PolicialRepository : IPolicialRepository
    {
        ApplicationDbContext _context;
        public PolicialRepository(ApplicationDbContext context) {
            _context = context;
        }
        public async Task<Policial> Create(Policial pol)
        {
            _context.Add(pol);
            await _context.SaveChangesAsync();
            return pol;
        }

        public async Task<IEnumerable<Policial>> GetAll()
        {
            return await _context.Policiais
                .Include(p => p.Opm)
                .ToListAsync();
        }

        public async Task<Policial> GetPolicial(string re)
        {
            return await _context.Policiais.Include(p => p.Opm)
                        .Include(p => p.medalhas)
                        .SingleOrDefaultAsync(p => p.Re == re);
        }

        public async Task<Policial> Update(Policial pol)
        {
            _context.Update(pol);
            await _context.SaveChangesAsync();
            return pol;
        }
    }
}
