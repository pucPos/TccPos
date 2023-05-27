using WebMedForms.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebMedForms.Data;
using WebMedForms.Models;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace LoginAspNetCoreEFCore.Controllers
{
    public class LoginController : Controller
    {
        private readonly Contexto _contexto;

        public LoginController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index(bool erroLogin)
        {
            if (erroLogin)
            {
                ViewBag.Erro = "Usuário e/ou senha estão incorretos";
            }
            if (User.Identity.IsAuthenticated)
            {
                
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logar(string Nome, string senha, bool manterlogado)
        {
            Usuario usuario = _contexto.Usuario.AsNoTracking().FirstOrDefault(x => x.Nome == Nome && x.Senha == senha);

            if (usuario != null)
            {
                int usuarioId = usuario.Id;
                string nome = usuario.Nome;
                string role = usuario.Role;

                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, nome));
                claims.Add(new Claim(ClaimTypes.Role, role));

                List<Claim> direitosAcesso = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier,usuarioId.ToString()),
                    new Claim(ClaimTypes.Name,nome),
                    new Claim(ClaimTypes.Role,role)
                };

                var identity = new ClaimsIdentity(direitosAcesso, CookieAuthenticationDefaults.AuthenticationScheme);
                var userPrincipal = new ClaimsPrincipal(new[] { identity });

                var authProperties = new AuthenticationProperties
                {
                    ExpiresUtc = DateTime.Now.AddMinutes(5),
                    IssuedUtc = DateTime.Now
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal, authProperties);

                if (role == "1")
                {
                    return RedirectToAction("Index", "Solicitacao");
                }
                else if (role == "2")
                {
                    return RedirectToAction("Index", "Aprovacao");
                }
                else if (role == "3")
                {
                    return RedirectToAction("Index", "Agendamento");
                }
            }
            else
            {
                return RedirectToAction("Index", new {erroLogin = true});

            }

            return Json(new { Msg = "Usuário não encontrado! Verifique suas credenciais!" });
        }

        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync();
            }
            return RedirectToAction("Index", "Login");
        }
    }
}
