using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorMovie.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorMovie.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        // GET: UsuarioController
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("Lista")]
        public IEnumerable<Usuario> Get()
        {
            List<Usuario> usuarios = new List<Usuario>()
            {
                new Usuario(){Titulo = "Sr", Nome = "Joao", Sobrenome = "Das Cove",
                    Email = "teste@teste.com", DataNascimento = DateTime.Now, Senha="123456",
                    ConfirmarSenha = "123456", TermosServ = true },
                new Usuario(){Titulo = "Sr", Nome = "Joao2", Sobrenome = "Das Cove2",
                    Email = "teste@teste.com", DataNascimento = DateTime.Now, Senha="123456",
                    ConfirmarSenha = "123456", TermosServ = true }
            };

            return usuarios;
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Create")]
        public async Task<ActionResult> Post([FromBody] Usuario usuario)
        {
            try
            {
                //Todo: adicionar o usuario na lista de usuarios
                return null;
            }
            catch
            {
                return null;
            }
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
