using Permuta.Dominio.Entidades;
using Permuta.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Permuta.Web.Controllers
{
    public class AnuncioController : Controller
    {
        private AnuncioRepositorio _repositorio;

        public ActionResult Index1()
        {
            _repositorio = new AnuncioRepositorio();
            var anunc = _repositorio.Anuncios;
            return View(anunc);
        }

        /**
        public ViewResult Alterar(int AnuncioID)
        {
            _repositorio = new AnuncioRepositorio();
            Anuncio anuncio = _repositorio.Anuncios
                .FirstOrDefault(p => p.AnuncioID == AnuncioID);

            return View(anuncio);
        }
        **/

        public ViewResult Alterar()
        {
            /**
            _repositorio = new ClienteRepositorio();
            var cliente = _repositorio.Clientes.Take(3);              
            **/
            return View();
        }

        [HttpPost]
        public ActionResult Alterar(Anuncio anuncio)
        {
            if (ModelState.IsValid)
            {
                _repositorio = new AnuncioRepositorio();
                _repositorio.Salvar(anuncio);

                TempData["mensagem"] = string.Format("{0} foi salvo com sucesso", anuncio.Titulo);

                return RedirectToAction("Index1");

            }
            return View(anuncio);
        }



        public ViewResult NovoAnuncio()
        {
            return View("Alterar", new Anuncio());
        }


        [HttpPost]
        public ActionResult Excluir(int AnuncioID)
       {
            _repositorio = new AnuncioRepositorio();

            Anuncio prod = _repositorio.Excluir(AnuncioID);

            if (prod != null)
            {
               TempData["mensagem"] = string.Format("{0} excluído com sucesso", prod.Titulo);
            }

            return RedirectToAction("Index1");
        }
    }
}