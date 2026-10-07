using LojaPet.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojaPet.Controllers
{
    public class ContaController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            // DEFININDO USUÁRIO E SENHA FIXOS PARA TESTE:
            string emailCorreto = "admin@email.com";
            string senhaCorreta = "123456";

            // Valida se o e-mail e a senha batem com os fixos
            if (email == emailCorreto && senha == senhaCorreta)
            {
                // Instancia o funcionário usando a orientação a objetos
                Funcionario funcionario = new Funcionario("Administrador", email, "Gerente");

                // Se autenticado com sucesso, vai para o Menu Principal
                return RedirectToAction("Index", "Home");
            }

            // Se errar, exibe a mensagem de erro na tela
            ModelState.AddModelError("", "E-mail ou senha incorretos");
            return View();
        }
    }
 }

