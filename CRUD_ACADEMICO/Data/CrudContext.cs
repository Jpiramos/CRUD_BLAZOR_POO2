using CRUD_ACADEMICO.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CRUD_ACADEMICO.Data
{
    public  class CrudContext: DbContext
    {
        public CrudContext(DbContextOptions<CrudContext> options) : base(options)
        {
        }
        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }


    }
}
