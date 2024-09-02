using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Toolbox.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace Toolbox.Views.Pages
{
    /// <summary>
    /// CompareFeedPage.xaml 的交互逻辑
    /// </summary>
    public partial class CompareFeedPage : INavigableView<CompareFeedPageViewModel>
    {
        public CompareFeedPageViewModel ViewModel { get; set; }

        public CompareFeedPage(CompareFeedPageViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;
            InitializeComponent();
        }

    }
}
