using Microsoft.Extensions.DependencyInjection;
using WinFormsApp1.Services;
using WinFormsApp1.ViewModels;
using WinFormsApp1.Views;

namespace WinFormsApp1;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // 1. 配置依赖注入容器
        var services = new ServiceCollection();
        services.AddSingleton<IGameService, GameService>(); // 注册服务
        services.AddTransient<MainViewModel>();            // 注册ViewModel
        services.AddTransient<Form1>();                    // 注册窗体

        // 2. 构建容器
        var serviceProvider = services.BuildServiceProvider();

        // 3. 从容器中获取窗体实例（它会自动注入ViewModel）
        var mainForm = serviceProvider.GetRequiredService<Form1>();

        // 4. 运行
        Application.Run(mainForm);
    }
}
