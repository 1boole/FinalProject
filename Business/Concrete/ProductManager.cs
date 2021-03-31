using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DateAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            if(product.ProductName.Length<2)
            {
                return new  ErrorResult(Messages.ProductNameInvalid);
            }
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDateResult<List<Product>> GetAll()
        {
            if(DateTime.Now.Hour==18)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            return new SuccessDateResult<List<Product>>(_productDal.GetAll(),Messages.ProductListed);
        }

        public IDateResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDateResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }

        public IDateResult<List<Product>> GetbyUnitPrice(decimal min, decimal max)
        {
            return new SuccessDateResult<List<Product>>( _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDateResult<List<ProductDetailDto>> GetProducDetails()
        {
            return new SuccessDateResult<List<ProductDetailDto>>(_productDal.GetProducDetails());
        }
    }
}
