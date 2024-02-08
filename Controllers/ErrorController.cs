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
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            var statusCodeResult =
                    HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage =
                            "Sorry, the resource you requested could not be found";
                    ViewBag.Path = statusCodeResult.OriginalPath;
                    ViewBag.QS = statusCodeResult.OriginalQueryString;
                    break;
            }

            return View("NotFound");
        }
    
        [AllowAnonymous]
        [Route("Error")]
        public IActionResult Error()
        {
            string logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Log.txt");
            
            try
            {
                // Recuperar dados da Exceçao
                var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

                ViewBag.ExceptionPath = exceptionHandlerPathFeature.Path;
                ViewBag.ExceptionMessage = exceptionHandlerPathFeature.Error.Message;
                ViewBag.StackTrace = exceptionHandlerPathFeature.Error.StackTrace;

                string dateTimeNow = DateTime.Now.ToString();
                string logText = $"[{dateTimeNow}] - Path: {exceptionHandlerPathFeature.Path} Message: {exceptionHandlerPathFeature.Error.Message} StackTrace: {exceptionHandlerPathFeature.Error.StackTrace}";
                System.IO.File.AppendAllText(logFilePath, logText, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText(logFilePath, $"Erro ao escrever no log: {ex.Message}", Encoding.UTF8);
            }

            return View("Error");
        }
    }
}
