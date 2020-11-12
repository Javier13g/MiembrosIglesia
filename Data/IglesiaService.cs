using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;

namespace MiembrosIglesia.Data
{
    public interface IServicioIglesia
    {
        Task<List<DatosMiembrosIglesia>> GetAllMiembros(Guid Uid);
        Task<DatosMiembrosIglesia> GetMiembros(Guid Tid);
        Task<bool> SetMiembros(DatosMiembrosIglesia T);


    }

    public class IglesiaService : IServicioIglesia
    {
        private readonly ApplicationDbContext db;
        public IglesiaService(ApplicationDbContext _dbContext)
        {
            db = _dbContext;
        }


        public async Task<List<DatosMiembrosIglesia>> GetAllMiembros(Guid _Uid)
        {
            List<DatosMiembrosIglesia> miembrosIglesias = await db.DatosMiembros
            .Where(t => t.Id_Usuario.Equals(_Uid))
            .ToListAsync<DatosMiembrosIglesia>();
            return await Task.FromResult(miembrosIglesias);
        }



        public Task<DatosMiembrosIglesia> GetMiembros(Guid Tid)
        {
            DatosMiembrosIglesia treasure = db.DatosMiembros
            .Where(t => t.Id.Equals(Tid)).FirstOrDefault();
            return Task.FromResult(treasure);
        }

        public Task<bool> SetMiembros(DatosMiembrosIglesia T)
        {
            bool status = false;
            try
            {
                db.DatosMiembros.Add(T);
                db.SaveChanges();
                status = true;
            }
            catch (Exception e)
            {
                status = false;
                Console.WriteLine(e.Message);
            }
            return Task.FromResult(status);
        }


    }
}