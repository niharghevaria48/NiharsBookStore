using NiharsBooks.Models;
using NiharsBookstore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NiharsBooks.DataAccess.Repository.IRepository
{
    class CategoryRepository :Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        void Update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if(objFromDb != null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }

        void ICategoryRepository.Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
