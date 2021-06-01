using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDePalavras.Library.Mail
{
    public class Constants
    {
        //POP3, IMAP -Ler e-mail
        //SMTP - Enviar Email

        //AUTENTICAÇÃO

        public readonly static string Usuario = "EmailUsadoParaEnvio";
        public readonly static string Senha = "SenhaDoEmailUsadoParaEnvio";

        //SERVIDOR SMTP
        public readonly static string ServerSMTP = "smtp.gmail.com";
        public readonly static int PortSMTP = 587;

    }
}
