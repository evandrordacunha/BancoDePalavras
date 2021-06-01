using BancoDePalavras.Library.Mail;
using BancoDePalavras.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDePalavras.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }        
        public IActionResult Contato()
        {
            return View();
        }
        //RECEBENDO DADOS DO FORMULARIO

        // POST => Request.Form["NameDoImput"]
        // GET  => Request.QueryString["NameDoImput"]

        //public IActionResult ReceberContato()
        //{
           
        //    Contato contato = new Contato();
        //    contato.Nome = Request.Form["nome"];
        //    contato.Email= Request.Form["email"];
        //    contato.Assunto= Request.Form["assunto"];
        //    contato.Mensagem = Request.Form["mensagem"];

        //    string conteudo = string.Format("Nome: {0}, E-mail: {1}, Assunto: {2}, Mensagem: {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);

        //    return new ContentResult() {Content= conteudo };
        //}

        public IActionResult ReceberContato([FromForm] Contato contato)
        {
            if (ModelState.IsValid)
            {
                //string conteudo = string.Format("Nome: {0}, E-mail: {1}, Assunto: {2}, Mensagem: {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);

                //Enviando e-mail (configurado na biblioteca Mail)
                EnviarEmail.EnviarMensagem(contato);

                ViewBag.Mensagem = "Mensagem enviada com sucesso!";
                return View("Contato", "Contato");
            }
            else
            {
                return View("Contato", "Contato");
                ViewBag.Mensagem = "Falha ao enviar a mensagem!";

            }
  
        }
    }
}
