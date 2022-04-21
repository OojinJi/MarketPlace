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
        ICategoryRepository Categories { get; }
        IPropertyRepository Properties { get; }
        ISubCategoryRepository SubCategories { get; }

        int Complete();

    }
}
