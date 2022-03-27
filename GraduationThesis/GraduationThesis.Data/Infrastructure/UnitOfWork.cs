using GraduationThesis.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GraduationThesisDbContext _context;

        public UnitOfWork(GraduationThesisDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
