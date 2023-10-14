using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FolhaPagamento.Controllers
{
    public class FuncionariosController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Nome"] = "Alana Martins";
            ViewData["Registro"] = "Registro: 1234";
            ViewData["Nivel"] = "Senioridade: Júnior";
            ViewData["Salario"] = "Salário: R$ 3000,00";
            return View();
        }

        public IActionResult Index1()
        {
            ViewData["Nome"] = "Natasha Letícia";
            ViewData["Registro"] = "Registro: 4321";
            ViewData["Nivel"] = "Senioridade: Júnior";
            ViewData["Salario"] = "Salário: R$ 3000,00";
            return View();
        }

        public IActionResult Index2()
        {
            ViewData["Nome"] = "Rayane Souza";
            ViewData["Registro"] = "Registro: 2143";
            ViewData["Nivel"] = "Senioridade: Pleno";
            ViewData["Salario"] = "Salário: R$ 5000,00";
            return View();
        }
    }
}
