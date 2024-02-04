using Contest.BizLogic.Models;
using Contest.BizLogic.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContestApp.Controllers;

[ApiController, Route("api/v1/[controller]")]
public class ActionController : ControllerBase
{
    private readonly IContestService _service;

    public ActionController(IContestService service)
    {
        _service = service;
    }

    /// <summary>
    /// Сохранить согласие на участие в акции
    /// </summary>
    /// <param name="userId">Идентификатор пользователя, который соглашается</param>
    [HttpPost("agreement")]
    public async Task<ActionResult> SaveAgreement([FromQuery]Guid userId)
    {
        await _service.SaveAction(userId, ActionType.AgreementGiven);
        return Ok();
    }

    
    /// <summary>
    /// Получить список выполненных действий пользователем
    /// </summary>
    /// <param name="userId">Идентификатор пользователя, по которому надо получить список выполненных действий</param>
    /// <returns>Список действий, которые пользователь выполнил</returns>
    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<ActionType>>> GetCompletedActions([FromQuery] Guid userId)
    {
        throw new NotImplementedException();
    }
}
