using BancoDePalavras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BancoDePalavras.Library.Mail
{
    public class EnviarEmail
    {
        public static void EnviarMensagem(Contato contato)
        {
            string conteudo = string.Format("Nome: {0}<br /> E-mail: {1}<br /> Assunto: {2}<br /> Mensagem: {3}<br />", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);

            //CONFIGURAR SMTP
            SmtpClient smtp = new SmtpClient(Constants.ServerSMTP, Constants.PortSMTP)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(Constants.Usuario, Constants.Senha)
            };

            //MONTAR A MENSAGEM DE E-MAIL

            MailMessage mensagem = new MailMessage();
            //Destino
            mensagem.To.Add(Constants.Usuario);
            //Origem
            mensagem.From = new MailAddress(Constants.Usuario);
            //Assunto
            mensagem.Subject = "Mensagem recebida pelo App Banco de Palavras";
            //Mensagem
            mensagem.IsBodyHtml = true;

            mensagem.Body = "<h1>Formulário de Contato</h1>" +conteudo;
           
            //ENVIANDO
            smtp.Send(mensagem);
        }
    }
}
