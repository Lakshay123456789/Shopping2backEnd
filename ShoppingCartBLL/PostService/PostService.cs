using AutoMapper;
using ShoppingCartDLL.Repositary.Interface;
using ShoppingCartModels.EntityModels;
using ShoppingCartModels.EntityModels.ModelDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartBLL.PostService
{
    public class PostService : IPostService
    {
        private readonly IGenericRepository<Post> _PostgenericRepository;

        private readonly IMapper _mapper;
        public PostService(IGenericRepository<Post> postgenericRepository, IMapper mapper)
        {
            _mapper = mapper;
            _PostgenericRepository = postgenericRepository;
        }


        public async Task InsertPost(PostDto postDto)
        {
            var post = _mapper.Map<Post>(postDto);
            await _PostgenericRepository.Insert(post);
        }


        public async Task<IEnumerable<Post>> GetAllMethod()
        {
            return await _PostgenericRepository.GetAll();
        } 
    }
}
