using DataAccess.Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public  class HabilidadService : IHabilidadService
    {
        private readonly MyDbContext _myDbContext;

        public HabilidadService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public async Task<Habilidad> Create(Habilidad habilidad)
        {
            _myDbContext.Habilidades.Add(habilidad);
            await _myDbContext.SaveChangesAsync();

            return habilidad;
        }

        public async Task Delete(int id)
        {
            var habilidad = await _myDbContext.Habilidades.FirstOrDefaultAsync(u => u.Id == id);
            if (habilidad != null)
            {
                _myDbContext.Habilidades.Remove(habilidad);
                await _myDbContext.SaveChangesAsync();
            }
        }

        public Task<List<Habilidad>> GetAll()
        {
            return _myDbContext.Habilidades.ToListAsync();
        }

        public async Task<Habilidad> GetById(int id)
        {
            return await _myDbContext.Habilidades.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task Update(Habilidad habilidad)
        {
            _myDbContext.Habilidades.Update(habilidad);
            await _myDbContext.SaveChangesAsync();
        }
    }
}
