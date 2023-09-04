using AutoMapper;
using ShoppingCartModels.EntityModels;
using ShoppingCartModels.ModelDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartBLL.Automapper
{
  public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDto, Product>();
        }
     
    }
}
