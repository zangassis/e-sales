using Commission.API.Models;
using Commission.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Commission.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommissionController : ControllerBase
{
    private readonly CommissionService _commissionService;

    public CommissionController(CommissionService commissionService)
    {
        _commissionService = commissionService;
    }

    [HttpPost]
    [Route("calculate")]
    public async Task<IActionResult> CalculateCommission([FromBody] CalculateCommissionRequest request)
    {
       await _commissionService.CalculateCommission(request.SaleId, request.SaleAmount);
       return Ok();
    }
}
