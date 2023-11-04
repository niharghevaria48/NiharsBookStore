using NiharsBooks.DataAccess.Repository.IRepository;
using NiharsBooks.Models;
using NiharsBookstore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace NiharsBooks.DataAccess.Repository
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(db);
            SP_Call = new SP_Call(_db);
            
        }
        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
