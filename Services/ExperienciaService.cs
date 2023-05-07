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
    public class ExperienciaService : IEmpresaService
    {
        private readonly MyDbContext _myDbContext;

        public ExperienciaService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public async Task<Experiencia> Create(Experiencia experiencia)
        {
            _myDbContext.Experiencias.Add(experiencia);
            await _myDbContext.SaveChangesAsync();

            return experiencia;
        }

        public async Task Delete(int id)
        {
            var experiencia = await _myDbContext.Experiencias.FirstOrDefaultAsync(u => u.Id == id);
            if (experiencia != null)
            {
                _myDbContext.Experiencias.Remove(experiencia);
                await _myDbContext.SaveChangesAsync();
            }
        }

        public Task<List<Experiencia>> GetAll()
        {
            return _myDbContext.Experiencias.ToListAsync();
        }

        public async Task<Experiencia> GetById(int id)
        {
            return await _myDbContext.Experiencias.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task Update(Experiencia experiencia)
        {
            _myDbContext.Experiencias.Update(experiencia);
            await _myDbContext.SaveChangesAsync();
        }
    }
}
