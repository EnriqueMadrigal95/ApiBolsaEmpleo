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
    public  class FormacionAcademicaService : IFormacionAcademicaService
    {
        private readonly MyDbContext _myDbContext;

        public FormacionAcademicaService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public async Task<FormacionAcademica> Create(FormacionAcademica formacion)
        {
            _myDbContext.Formaciones.Add(formacion);
            await _myDbContext.SaveChangesAsync();

            return formacion;
        }

        public async Task Delete(int id)
        {
            var formacion = await _myDbContext.Formaciones.FirstOrDefaultAsync(u => u.Id == id);
            if (formacion != null)
            {
                _myDbContext.Formaciones.Remove(formacion);
                await _myDbContext.SaveChangesAsync();
            }
        }

        public Task<List<FormacionAcademica>> GetAll()
        {
            return _myDbContext.Formaciones.ToListAsync();
        }

        public async Task<FormacionAcademica> GetById(int id)
        {
            return await _myDbContext.Formaciones.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task Update(FormacionAcademica formacion)
        {
            _myDbContext.Formaciones.Update(formacion);
            await _myDbContext.SaveChangesAsync();
        }
    }
}
