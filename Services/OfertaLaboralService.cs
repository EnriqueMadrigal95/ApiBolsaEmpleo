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
    public  class OfertaLaboralService
    {
        private readonly MyDbContext _myDbContext;

        public OfertaLaboralService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public async Task<OfertaLaboral> Create(OfertaLaboral ofertaLaboral)
        {
            _myDbContext.OfertasLaborales.Add(ofertaLaboral);
            await _myDbContext.SaveChangesAsync();

            return ofertaLaboral;
        }

        public async Task Delete(int id)
        {
            var oferta_laboral = await _myDbContext.OfertasLaborales.FirstOrDefaultAsync(u => u.Id == id);
            if (oferta_laboral != null)
            {
                _myDbContext.OfertasLaborales.Remove(oferta_laboral);
                await _myDbContext.SaveChangesAsync();
            }
        }

        public Task<List<OfertaLaboral>> GetAll()
        {
            return _myDbContext.OfertasLaborales.ToListAsync();
        }

        public async Task<OfertaLaboral> GetById(int id)
        {
            return await _myDbContext.OfertasLaborales.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task Update(OfertaLaboral oferta_Laboral)
        {
            _myDbContext.OfertasLaborales.Update(oferta_Laboral);
            await _myDbContext.SaveChangesAsync();
        }
    }
}
