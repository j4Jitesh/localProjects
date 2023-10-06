using Microsoft.AspNetCore.Mvc;

namespace WebApp.Wasm;

public class DevexpressController : Controller
{
    /// <summary>
    /// Request fallback to this controller
    /// </summary>
    /// <returns></returns>
    public IActionResult Index()
    {
        return View("~/Pages/_Devexpress.cshtml");
    }
}

