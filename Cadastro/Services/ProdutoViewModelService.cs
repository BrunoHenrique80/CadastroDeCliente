using AutoMapper;
using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces;
using Cadastro.Interfaces;
using Cadastro.ViewModels;
using System.Collections.Generic;

namespace Cadastro.Services
{
    public class ProdutoViewModelService : IProdutoViewModelService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProdutoViewModelService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public ProdutoViewModel Get(int id)
        {
            var entity = _productRepository.Get(id);
            if (entity == null)
                return null;

            return _mapper.Map<ProdutoViewModel>(entity);
        }

        public IEnumerable<ProdutoViewModel> GetAll()
        {
            var list = _productRepository.GetAll();
            if (list == null)
                return new ProdutoViewModel[] { };

            return _mapper.Map<IEnumerable<ProdutoViewModel>>(list);
        }

        public void Insert(ProdutoViewModel viewModel)
        {
            var entity = _mapper.Map<Product>(viewModel);

            _productRepository.Insert(entity);
        }

        public void Update(ProdutoViewModel viewModel)
        {
            var entity = _mapper.Map<Product>(viewModel);

            _productRepository.Update(entity);
        }
    }
}