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
    [Route("process-commission")]
    public async Task<IActionResult> ProcessCommission([FromBody] ProcessCommissionRequest request)
    {
       await _commissionService.ProcessCommission(request.SaleId, request.Currency, request.SaleAmount);
       return Ok();
    }
}
