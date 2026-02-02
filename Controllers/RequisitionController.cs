using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers;

[Route("Requisition")]
public class RequisitionController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("submit")]
    public IActionResult Submit(RequisitonDto dto)
    {
        if(!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(dto);
    }
}
