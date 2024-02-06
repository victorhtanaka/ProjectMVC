using System;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers
{
    public class ErrorController : Controller
    {
        [AllowAnonymous]
        [Route("Error")]
        public IActionResult Error()
        {
            // Recuperar dados da Exceçao
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            ViewBag.ExceptionPath = exceptionHandlerPathFeature.Path;
            ViewBag.ExceptionMessage = exceptionHandlerPathFeature.Error.Message;
            ViewBag.StackTrace = exceptionHandlerPathFeature.Error.StackTrace;

            string logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Log.txt");
            string dateTimeNow = DateTime.Now.ToString();
            string logText = $"[{dateTimeNow}] - Path: {exceptionHandlerPathFeature.Path} Message: {exceptionHandlerPathFeature.Error.Message} StackTrace: {exceptionHandlerPathFeature.Error.StackTrace}";

            try
            {
                System.IO.File.AppendAllText(logFilePath, logText, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                // Trate qualquer exceção relacionada à gravação no log, se necessário.
                Console.WriteLine($"Erro ao escrever no log: {ex.Message}");
            }

            return View("Error");
        }
    }
}
