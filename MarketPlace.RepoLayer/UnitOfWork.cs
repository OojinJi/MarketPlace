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
            Categories = new CategoryRepository(_context);
            Credentials = new CredentialRepository(_context);
            Departments = new DepartmentRepository(_context);
            Manufacturers = new ManufacturerRepository(_context);   
            Products = new ProductRepository(_context); 
            Properties = new PropertyRepository(_context);
            SubCategories = new SubCategoryRepository(_context);
            TechSpecFilters = new TechSpecFilterRepository(_context);   
            TypeFilters = new TypeFilterRepository(_context);
            Users = new UserRepository(_context);   
        }
        public CategoryRepository Categories { get; set; } 
        public PropertyRepository Properties { get; set; }
        public SubCategoryRepository  SubCategories { get; set; }
        public CredentialRepository Credentials { get; set; }

        public DepartmentRepository Departments {get; set;}

        public ManufacturerRepository Manufacturers {get; set;}

        public ProductRepository Products {get; set;}

        public TechSpecFilterRepository TechSpecFilters {get; set;}

        public TypeFilterRepository TypeFilters { get; set; }

        public UserRepository Users { get; set; }

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
