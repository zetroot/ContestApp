using Contest.BizLogic.Models;

namespace Contest.BizLogic.Services;

public interface IContestService
{
    /// <summary>
    /// Сохранить факт совершения действия пользователем.
    /// </summary>
    /// <param name="userId">Идентификатор пользователя</param>
    /// <param name="actionType">Тип совершенного действия</param>
    Task SaveAction(Guid userId, ActionType actionType);
}
