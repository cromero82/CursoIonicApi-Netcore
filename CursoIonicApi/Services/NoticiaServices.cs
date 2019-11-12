using CursoIonicApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoIonicApi.Services
{
    public class NoticiaServices
    {
        private NoticiasDbContext dbContext { get; set; }
        public NoticiaServices(NoticiasDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

    }
}
