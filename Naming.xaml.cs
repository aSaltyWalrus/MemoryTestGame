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
    /// Interaction logic for Naming.xaml
    /// </summary>
    public partial class Naming : Page
    {

        int count = 0, correctAmount = 0;
        ItemManager ItemManager;
        Item[] items;
        int[] correctAmountArr = new int[4];
        public Naming(ItemManager itemManager)
        {
            InitializeComponent();
            ItemManager = itemManager;
            items = ItemManager.randomizeItems();
            Uri resourceUri = new Uri("/img/" + items[0].Path + ".jpg", UriKind.Relative);
            NamingImg.Source = new BitmapImage(resourceUri);
        }

        private void Naming_Confirm_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Input.Text.ToLower() == items[count].Name)
            {
                correctAmount++;
                Input.Text = "";
            }
            count++;
            if (count >= 59)
            {
                correctAmountArr[0] = correctAmount;
                NamingFrame.Content = new WordToPicure(ItemManager, correctAmountArr);
            }
            else
            {
                Uri resourceUri = new Uri("/img/" + items[count].Path + ".jpg", UriKind.Relative);
                NamingImg.Source = new BitmapImage(resourceUri);
            }
        }
    }
}
