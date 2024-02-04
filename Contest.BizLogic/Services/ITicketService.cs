namespace Contest.BizLogic.Services;

public interface ITicketService
{
    /// <summary>
    /// Получить номер билета, который выпал пользователю
    /// </summary>
    /// <param name="userId">Идентификатор пользователя</param>
    /// <returns>Номер билета, который выпал пользователю</returns>
    Task<long> GetUserTicket(Guid userId);
}
