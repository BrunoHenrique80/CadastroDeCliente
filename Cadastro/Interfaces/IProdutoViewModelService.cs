using Cadastro.ViewModels;
using System.Collections.Generic;

namespace Cadastro.Interfaces
{
    public interface IProdutoViewModelService
    {
        ProdutoViewModel Get(int id);
        IEnumerable<ProdutoViewModel> GetAll();
        void Insert(ProdutoViewModel viewModel);
        void Update(ProdutoViewModel viewModel);
        void Delete(int id);
    }
}
