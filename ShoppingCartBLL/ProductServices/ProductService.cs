using AutoMapper;
using ShoppingCartDLL.Repositary.Interface;
using ShoppingCartModels.EntityModels;
using ShoppingCartModels.ModelDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartBLL.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> _genericRepository;
        private readonly IMapper _mapper;
        public ProductService(IGenericRepository<Product> genericRepository, IMapper mapper)
        {
            _mapper= mapper;
            _genericRepository = genericRepository;
        }

        public async Task<IEnumerable<Product>> GetAllMethod()
        {
            return await _genericRepository.GetAll();
        }
        public async Task<Product> GetByIdMethod(Guid id)
        {
            return await _genericRepository.GetById(id);
        }
        public async Task InsertMethod(ProductDto obj)
        {       
            var product = _mapper.Map<Product>(obj);
            await _genericRepository.Insert(product);
        }
        public async Task UpdateMethod(ProductDto obj,Guid Id)
        {
            var res = await _genericRepository.GetById(Id);
            if (res != null)
            {
                //var product = _mapper.Map<Product>(obj);
                //product.Id = Id;
                //res.ProductName = obj.ProductName;
                //res.ProductPrice = obj.ProductPrice;
                //res.ProductCatagory = obj.ProductCatagory;
                //res.ProductQuantity = obj.ProductQuantity;
                //res.ProductDescription = obj.ProductDescription;
                _mapper.Map(obj,res);

                await _genericRepository.Update(res);
            }
           
        }
        public async Task DeleteMethod(Guid obj)
        {
            await _genericRepository.Delete(obj);
        }

    }
}
