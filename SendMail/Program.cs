using System;

 
using System.Net.Mail;
 
 
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
namespace SendMail
{
    class Program
    {
        static void Main(string[] args)
        {
             
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress("alvaroku123@gmail.com", "TestMail", System.Text.Encoding.UTF8);//Correo de salida
                correo.To.Add("dual.alvaro.ku@gmail.com"); //Correo destino?
                //correo.To.Add("jesus.18070057@itsmotul.edu.mx");
                correo.Subject = "Correo de prueba"; //Asunto
                correo.Body = "<button onclick='alert(2)'>press</button>Este es un correo de prueba desde c# para indicarte que debes sacar 2"; //Mensaje del correo
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
                smtp.Port = 25; //Puerto de salida
                smtp.Credentials = new System.Net.NetworkCredential("alvaroku123@gmail.com", "fbnmlbaokicdivdr");//Cuenta de correo
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                smtp.EnableSsl = true;//True si el servidor de correo permite ssl
                smtp.Send(correo);
                Console.WriteLine("Hello World!");
            
        }
    }
}
