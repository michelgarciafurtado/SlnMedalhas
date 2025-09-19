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
    public class OpmRepository: IOpmRepository
    {
        ApplicationDbContext _context;

        public OpmRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Opm> Create(Opm opm)
        {
            _context.Add(opm);
            await _context.SaveChangesAsync();
            return opm;
        }

        public async Task<IEnumerable<Opm>> GetAll()
        {
            return await _context.Opms.ToListAsync();
        }

        public async Task<Opm> GetOpm(string codOpm)
        {
            return await _context.Opms.FindAsync(codOpm);
        }

        public async Task<Opm> Update(Opm opm)
        {
            _context.Update(opm);
            await _context.SaveChangesAsync();
            return opm;
        }
    }
}
