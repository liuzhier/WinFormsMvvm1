namespace WinFormsApp1.Models;

/// <summary>
/// 游戏回合结果
/// </summary>
public enum GameOutcome
{
    /// <summary>
    /// 胜利
    /// </summary>
    Win,

    /// <summary>
    /// 失败
    /// </summary>
    Lose,

    /// <summary>
    /// 平局
    /// </summary>
    Draw,
}

/// <summary>
/// 游戏结果
/// </summary>
/// <param name="PlayerAction">玩家动作</param>
/// <param name="CpuAction">电脑动作</param>
/// <param name="Outcome">游戏实际结果</param>
public record GameResult(GameAction PlayerAction, GameAction CpuAction, GameOutcome Outcome);
