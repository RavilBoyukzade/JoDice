using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JoDice.Models;
using Microsoft.AspNetCore.Mvc;
using MailKit.Net.Smtp;
using MimeKit;

namespace JoDice.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Send(string name,string subject, string email,string msg)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("JoDice","no-reply@content.com"));
            message.To.Add(new MailboxAddress("Ravil", "ravilib@code.edu.az"));
            message.Subject = subject;
            message.Body = new TextPart("html")
            {
                Text = "From: " + name +
                "<br>" +
                "Contact information: " + email +
                "<br>" +
                "Message: " + msg
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587);
                client.Authenticate("ravilib@code.edu.az","Norahi940");
                client.Send(message);
                client.Disconnect(false);
            }


                return View("Index");
        }
    }
}
