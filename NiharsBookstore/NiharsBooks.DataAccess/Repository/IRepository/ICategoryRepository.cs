using NiharsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NiharsBooks.DataAccess.Repository.IRepository
{
    interface ICategoryRepository
    {
        void Update(Category category);
    }
}
