using Prism.Ioc;
using PrismApplicationSample.Model;
using PrismApplicationSample.Views;
using System.Windows;

namespace PrismApplicationSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes( IContainerRegistry containerRegistry )
        {
            containerRegistry.Register<IModelRepository, ModelRepository>();
        }
    }
}
