using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;
using TeduShop.Common;

namespace TeduShop.Service
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private ITagRepository _tagRepository;

        private IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork, ITagRepository _tagRepository)
        {
            this._productRepository = productRepository;
            this._tagRepository = _tagRepository;
            this._unitOfWork = unitOfWork;
        }

        public Product Add(Product product)
        {
            var addedProduct = _productRepository.Add(product);

            if (!string.IsNullOrEmpty(product.StringTags))
            {
                string[] tags = product.StringTags.Split(',');

                foreach (var tag in tags)
                {
                    var tagId = StringHelper.ToUnsignString(tag);

                    if (_tagRepository.Count(x => x.Id == tagId) == 0)
                    {
                        Tag newTag = new Tag();
                        newTag.Id = tagId;
                        newTag.Name = tag;
                        newTag.Type = CommonConstants.ProductTag;
                        _tagRepository.Add(newTag);

                        product.Tags.Add(newTag);
                    }
                    else
                    {
                        Tag exitingTag = _tagRepository.GetSingleByCondition(t => t.Id == tagId);
                        product.Tags.Add(exitingTag);
                    }
                }
            }

            return addedProduct;
        }

        public Product Delete(int id)
        {
            return _productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public IEnumerable<Product> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _productRepository.GetMulti(x => x.Name.Contains(keyword) || x.Description.Contains(keyword));
            else
                return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);

            if (!string.IsNullOrEmpty(product.StringTags))
            {
                string[] tags = product.StringTags.Split(',');

                foreach (var tag in tags)
                {
                    var tagId = StringHelper.ToUnsignString(tag);

                    if (_tagRepository.Count(x => x.Id == tagId) == 0)
                    {
                        Tag newTag = new Tag();
                        newTag.Id = tagId;
                        newTag.Name = tag;
                        newTag.Type = CommonConstants.ProductTag;
                        _tagRepository.Add(newTag);

                        product.Tags.Add(newTag);
                    }
                }
            }
        }
    }
}