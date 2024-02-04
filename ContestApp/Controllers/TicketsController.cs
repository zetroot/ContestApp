using Contest.BizLogic.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContestApp.Controllers;

[ApiController, Route("api/v1/[controller]")]
public class TicketsController : ControllerBase
{
    private readonly ITicketService _service;

    public TicketsController(ITicketService service)
    {
        _service = service;
    }

    /// <summary>
    /// Получить номер билетика пользователя
    /// </summary>
    /// <param name="userId">Идентификатор пользователя</param>
    /// <returns>Номер билета</returns>
    [HttpGet]
    public async Task<ActionResult<long>> GetUserTicket([FromQuery] Guid userId)
    {
        return await _service.GetUserTicket(userId);
    }
}
