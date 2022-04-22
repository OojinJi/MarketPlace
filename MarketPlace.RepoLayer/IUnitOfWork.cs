using MarketPlace.RepoLayer.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.RepoLayer
{
    public interface IUnitOfWork:IDisposable
    {
        CategoryRepository Categories { get; }
        CredentialRepository Credentials { get; }
        DepartmentRepository Departments { get; }
        ManufacturerRepository Manufacturers { get; }
        ProductRepository Products { get; }
        PropertyRepository Properties { get; }
        SubCategoryRepository SubCategories { get; }
        TechSpecFilterRepository TechSpecFilters { get; }   
        TypeFilterRepository TypeFilters { get; }   
        UserRepository Users { get; }


        int Complete();

    }
}
