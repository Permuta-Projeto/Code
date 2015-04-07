using Permuta.Dominio.Entidades;
using Permuta.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Permuta.Web.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteRepositorio _repositorio;

        /**
        public ViewResult Index2(int ClienteID)
        {
            _repositorio = new ClienteRepositorio();
            Cliente cliente = _repositorio.Clientes
                .FirstOrDefault(p => p.ClienteID == ClienteID);

            return View(cliente);
        }
         * **/

        public ViewResult Index2()
        {
            /**
            _repositorio = new ClienteRepositorio();
            var cliente = _repositorio.Clientes.Take(3);              
            **/
            return View();
        }


        [HttpPost]
        public ActionResult Index2(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _repositorio = new ClienteRepositorio();
                _repositorio.Salvar(cliente);

                TempData["mensagem"] = string.Format("{0} foi salvo com sucesso", cliente.Nome);

                return RedirectToAction("Index");

            }
            return View(cliente);
        }



        public ViewResult NovoCliente()
        {
            return View("Index2", new Cliente());
        }
    }
}