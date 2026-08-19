using Microsoft.AspNetCore.Mvc;

namespace mvc2026;

public class ClientesController : Controller
{
    public IActionResult Cadastrar()
    {
        return View();
    }
}
