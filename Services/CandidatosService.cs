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
    public  class CandidatosService : ICandidatosService
    {
        private readonly MyDbContext _myDbContext;

        public CandidatosService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public Task<List<Candidato>> GetAll()
        {
            return _myDbContext.Candidato.ToListAsync();
        }

        public async Task<Candidato> GetById(int id)
        {
            return await _myDbContext.Candidato.FirstOrDefaultAsync(u => u.Id == id);
        }


        public async Task<Candidato> Create(Candidato candidato)
        {
            _myDbContext.Candidato.Add(candidato);
            await _myDbContext.SaveChangesAsync();

            return candidato;
        }

        public async Task Update(Candidato candidato)
        {
            _myDbContext.Candidato.Update(candidato);
            await _myDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var candidato = await _myDbContext.Candidato.FirstOrDefaultAsync(u => u.Id == id);
            if (candidato != null)
            {
                _myDbContext.Candidato.Remove(candidato);
                await _myDbContext.SaveChangesAsync();
            }
        }
    }
}
