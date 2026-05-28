using WinFormsApp1.Models;

namespace WinFormsApp1.Services;

public interface IGameService
{
    GameAction GetCpuAction();

    GameResult GetResult(GameAction playerAction);
}