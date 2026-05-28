using WinFormsApp1.Models;
using WinFormsApp1.ViewModels;

namespace WinFormsApp1.Views;

public partial class Form1 : Form
{
    private readonly MainViewModel _viewModel;

    public Form1(MainViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;

        // 绑定时，第三个参数必须是生成出来的公有属性名（首字母大写）
        label_playerAction.DataBindings.Add(nameof(Label.Text), _viewModel, nameof(_viewModel.PlayerActionText));
        label_cpuAction.DataBindings.Add(nameof(Label.Text), _viewModel, nameof(_viewModel.CpuActionText));
        label_checkReturn.DataBindings.Add(nameof(Label.Text), _viewModel, nameof(_viewModel.ResultText));

        // 绑定按钮事件到自动生成的 Command
        button_石头.Click += (s, e) => _viewModel.PlayActionCommand.Execute(GameAction.Rock);
        button_剪刀.Click += (s, e) => _viewModel.PlayActionCommand.Execute(GameAction.Scissors);
        button_布.Click += (s, e) => _viewModel.PlayActionCommand.Execute(GameAction.Paper);
    }
}
