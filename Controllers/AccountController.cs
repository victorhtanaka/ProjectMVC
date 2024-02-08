using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

public class AccountController : Controller
{
    private readonly ProjectContext _db;

    public AccountController(ProjectContext db)
    {
        _db = db;
    }

    public IActionResult Login()
    {
        ClaimsPrincipal claimUser = HttpContext.User;

        if (claimUser.Identity.IsAuthenticated)
            return RedirectToAction("Index", "Home");

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(AdminInfo modelLogin)
    {
        var admin = _db.AdminInfos.Find(modelLogin.LoginAdmin);
        if (admin == null)
        {
            return NotFound("Login ou senha incorretos");
        }
        // Verificação da presença de um login valido no BD
        if (modelLogin.LoginAdmin == admin.LoginAdmin &&
            modelLogin.SenhaAdmin == admin.SenhaAdmin
            )
        { 
            _db.Entry(admin).CurrentValues.SetValues(modelLogin);
            _db.SaveChanges();
            List<Claim> claims = new List<Claim>() { 
                new Claim(ClaimTypes.NameIdentifier, modelLogin.LoginAdmin),
                new Claim("OtherProperties","Example Role")
            
            };

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                CookieAuthenticationDefaults.AuthenticationScheme );

            AuthenticationProperties properties = new AuthenticationProperties() { 
            
                AllowRefresh = true,
                IsPersistent = modelLogin.RememberMe
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity), properties);
        
            return RedirectToAction("Index", "Home");
        }

        ViewData["ValidateMessage"] = "user not found";
        return View();
    }
}

