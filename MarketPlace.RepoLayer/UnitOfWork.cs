using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketPlace.DataLayer;
using MarketPlace.RepoLayer;

namespace MarketPlace.RepoLayer.Repositorys
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MarketPlaceEntities1 _context;
        public UnitOfWork(MarketPlaceEntities1 context)
        {
            _context = context;
            Categories = new Category(_context);
            Properties = new Property(_context);
            SubCategories = new SubCategory(_context);
        }
        public ICategoryRepository Categories { get; set; } 
        public IPropertyRepository Properties { get; set; }
        public ISubCategoryRepository  SubCategories { get; set; }
        
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
