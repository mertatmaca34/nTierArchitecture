using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, SampleContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using var context = new SampleContext();
            var result = from p in context.Products
                         join c in context.Categories
                         on p.CategoryId equals c.CategoryId
                         select new ProductDetailDto
                         {
                             CategoryName = c.CategoryName,
                             ProductId = p.ProductId,
                             ProductName = p.ProductName,
                             UnitsInStock = p.UnitInStock
                         };
            return result.ToList();
        }
    }
}
