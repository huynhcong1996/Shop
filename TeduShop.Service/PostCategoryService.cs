using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IPostCategoryService
    {
        PostCategory Add(PostCategory PostCategory);
        void Update(PostCategory PostCategory);
        PostCategory delete(int id);
        IEnumerable<PostCategory> GetAll();
        IEnumerable<PostCategory> GetAllByParentId(int ParenId);
        PostCategory GetById(int id);
    }
    public class PostCategoryService : IPostCategoryService
    {
        private IPostCategoryRepository object1;
        private IUnitOfWork object2;
        IPostCategoryRepository _postCategoryRepository;
        IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRepository object1, IUnitOfWork object2)
        {
            this.object1 = object1;
            this.object2 = object2;
        }

        public PostCategoryService(IPostCategoryRepository postCategoryRepository, UnitOfWork unitOfWork)
        {
            this._postCategoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }
        public PostCategory Add(PostCategory PostCategory)
        {
            return _postCategoryRepository.Add(PostCategory);
        }

        public PostCategory delete(int id)
        {
            return _postCategoryRepository.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryRepository.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentId(int ParenId)
        {
            return _postCategoryRepository.GetMulti(x => x.Status && x.ParentID == ParenId);
        }

        public PostCategory GetById(int id)
        {
            return _postCategoryRepository.GetSingleById(id);
        }
        public void Update(PostCategory PostCategory)
        {
            _postCategoryRepository.Update(PostCategory);
        }
    }
}
