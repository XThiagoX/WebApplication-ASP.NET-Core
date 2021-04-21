using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult cadastrocarro([FromForm] Carro carro)
        {
            if (ModelState.IsValid)
            {
                string conteudo = string.Format("Fabricaante: {0}, " +
                                 "Modelo: {1}, " +
                                 "Vesão: {2}, " +
                                 "Ano: {3}, " +
                                 "Cor: {4}. ",
                                 carro.fabricante, carro.modelo, carro.versao, carro.ano, carro.cor);

                return new ContentResult() { Content = conteudo };
            }
            else
            {
                return View("Index");
            }
        }
    }
}
