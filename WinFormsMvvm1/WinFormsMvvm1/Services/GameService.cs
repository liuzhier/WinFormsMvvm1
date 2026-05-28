using WinFormsApp1.Models;

namespace WinFormsApp1.Services;

public class GameService : IGameService
{
    private static readonly Random Rnd = new();

    /// <summary>
    /// 随机生成电脑动作
    /// </summary>
    /// <returns>电脑动作</returns>
    public GameAction GetCpuAction()
    {
        var values = Enum.GetValues<GameAction>();
        return values[Rnd.Next(values.Length)];
    }

    /// <summary>
    /// 判断游戏结果
    /// </summary>
    /// <param name="playerAction">玩家动作</param>
    /// <returns>本回合游戏结果</returns>
    public GameResult GetResult(GameAction playerAction)
    {
        var cpuAction = GetCpuAction();
        var outcome = GameOutcome.Draw; // 默认平局

        // 判断输赢逻辑
        if (playerAction != cpuAction)
        {
            outcome = (playerAction, cpuAction) switch
            {
                (GameAction.Rock, GameAction.Scissors) => GameOutcome.Win,
                (GameAction.Scissors, GameAction.Paper) => GameOutcome.Win,
                (GameAction.Paper, GameAction.Rock) => GameOutcome.Win,
                _ => GameOutcome.Lose // 其他情况都是输
            };
        }

        return new(playerAction, cpuAction, outcome);
    }
}
