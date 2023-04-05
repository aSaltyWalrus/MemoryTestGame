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

namespace Memory_Test_Game
{
    /// <summary>
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : Page
    {
        int [] correctAmountArr;
        public Results(int[] inputCorrectAmountArr)
        {
            InitializeComponent();
            correctAmountArr = inputCorrectAmountArr;
            Naming.Content = "Naming: " + correctAmountArr[0] + " / 60";
            WordToPicture.Content = "Word To Picture: " + correctAmountArr[1] + " / 60";
            PictureSort.Content = "Picture Sort: " + correctAmountArr[2] + " / 120";
            WordSort.Content = "Word Sort: " + correctAmountArr[3] + " / 120";
            Total.Content = "Total: " + correctAmountArr.Sum() + " / 360";
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }
    }
}
