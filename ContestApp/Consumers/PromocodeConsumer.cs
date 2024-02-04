using Contest.BizLogic.Models;
using Contest.BizLogic.Services;
using MassTransit;

namespace ContestApp.Consumers;

public class PromocodeConsumer : IConsumer<PromocodeActivated>
{
    private readonly IContestService _service;

    public PromocodeConsumer(IContestService service)
    {
        _service = service;
    }

    public async Task Consume(ConsumeContext<PromocodeActivated> context)
    {
        await _service.SaveAction(context.Message.PromocodeOwnerId, ActionType.PromocodeShared);
    }
}

/// <summary>
/// Событие об активации промокода
/// </summary>
/// <remarks>Его нам предоставит команда, которая занимается микросервисами продаж</remarks>
/// <param name="PromocodeOwnerId">Идентификатор пользователя, чей промокод активировали</param>
public record PromocodeActivated(Guid PromocodeOwnerId);
