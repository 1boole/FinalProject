using Core;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDateResult<List<Product>> GetAll();
        IDateResult<List<Product>> GetAllByCategoryId(int id);
        IDateResult<List<Product>> GetbyUnitPrice(decimal min, decimal max);
        IDateResult<List<ProductDetailDto>> GetProducDetails();
        IResult Add(Product product);
    }
}
