using Cadastro.Interfaces;
using Cadastro.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutoViewModelService _produtoViewModelService;
        public ProdutosController(IProdutoViewModelService produtoViewModelService)
        {
            _produtoViewModelService = produtoViewModelService;
        }

        public ActionResult Index()
        {
            var list = _produtoViewModelService.GetAll();
            return View(list);
        }


        public ActionResult Details(int id)
        {
            var viewModel = _produtoViewModelService.Get(id);
            return View(viewModel);
        }

  
        public ActionResult Create()
        {
            return View();
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel viewModel)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    _produtoViewModelService.Insert(viewModel);

                    return RedirectToAction(nameof(Index));
                }
                return View(viewModel);
            }
            catch
            {
                return View(viewModel);
            }
        }

        public ActionResult Edit(int id)
        {
            var viewModel = _produtoViewModelService.Get(id);
            return View(viewModel);
        }

    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProdutoViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _produtoViewModelService.Update(viewModel);

                    return RedirectToAction(nameof(Index));
                }
                return View(viewModel);
            }
            catch
            {
                return View(viewModel);
            }
        }

      
        public ActionResult Delete(int id)
        {
            var viewModel = _produtoViewModelService.Get(id);
            return View(viewModel);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _produtoViewModelService.Delete(id);

                    return RedirectToAction(nameof(Index));
                }

                var viewModel = _produtoViewModelService.Get(id);
                return View(viewModel);
            }
            catch
            {
                var viewModel = _produtoViewModelService.Get(id);
                return View(viewModel);
            }
        }
    }
}
