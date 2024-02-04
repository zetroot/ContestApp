using Contest.BizLogic.Models;
using Contest.BizLogic.Services;
using MassTransit;

namespace ContestApp.Consumers;

public class CheckoutConsumer : IConsumer<UserBoughtSomething>
{
    private readonly IContestService _service;
    public async Task Consume(ConsumeContext<UserBoughtSomething> context)
    {
        await _service.SaveAction(context.Message.UserId, ActionType.BoughtSomething);
    }
}

/// <summary>
/// Это событие покупки чего-то пользователем
/// </summary>
/// <remarks>Его нам предоставит команда, которая занимается микросервисами продаж</remarks>
/// <param name="UserId">Идентификатор пользователя, совершившего покупку</param>
public record UserBoughtSomething(Guid UserId);
