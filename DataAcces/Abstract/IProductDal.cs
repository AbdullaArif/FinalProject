using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll(Expression<Func<Product, bool>> filter=null);
        void Add(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        Product Get(Expression<Func<Product,bool>>filter);
    }
}
