using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WinFormsApp1.Models;
using WinFormsApp1.Services;

namespace WinFormsApp1.ViewModels;


public partial class MainViewModel(IGameService GameService) : ObservableObject
{
    [ObservableProperty]
    public partial string PlayerActionText { get; set; }

    [ObservableProperty]
    public partial string CpuActionText { get; set; }

    [ObservableProperty]
    public partial string ResultText { get; set; } = "游戏未开始！"; // 可以直接给默认值


    /// <summary>
    /// 编译器自动生成 PlayActionCommand
    /// </summary>
    /// <param name="action">动作</param>
    [RelayCommand]
    private void PlayAction(GameAction action)
    {
        // 直接使用主构造函数注入的 GameService，不需要声明私有变量了
        var result = GameService.GetResult(action);

        // 给自动生成的属性赋值，触发界面刷新
        PlayerActionText = result.PlayerAction.ToString();
        CpuActionText = result.CpuAction.ToString();
        ResultText = result.Outcome switch
        {
            GameOutcome.Win => "赢",
            GameOutcome.Lose => "输",
            _ => "平局"
        };
    }
}
