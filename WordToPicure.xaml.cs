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
    /// Interaction logic for WordToPicure.xaml
    /// </summary>
    public partial class WordToPicure : Page
    {
        ItemManager itemManager;
        Item[] items, words = new Item[48];
        Image[] images;
        Image currImg = null;
        int count = 0, correctAmount = 0;
        Random random = new Random();
        int[] correctAmountArr;
        public WordToPicure(ItemManager inputItemManager, int[] inputCorrectAmountArr)
        {
            InitializeComponent();
            correctAmountArr = inputCorrectAmountArr;
            Image[] imagesArr = { WtpImg1, WtpImg2, WtpImg3, WtpImg4, WtpImg5, WtpImg6, WtpImg7, WtpImg8, WtpImg9, WtpImg10, WtpImg11, WtpImg12,
                WtpImg13, WtpImg14, WtpImg15, WtpImg16, WtpImg17, WtpImg18, WtpImg19, WtpImg20, WtpImg21, WtpImg22, WtpImg23, WtpImg24, WtpImg25,
                WtpImg26, WtpImg27, WtpImg28, WtpImg29, WtpImg30, WtpImg31, WtpImg32, WtpImg33, WtpImg34, WtpImg35, WtpImg36, WtpImg37, WtpImg38,
                WtpImg39, WtpImg40, WtpImg41, WtpImg42, WtpImg43, WtpImg44, WtpImg45, WtpImg46, WtpImg47, WtpImg48, WtpImg49, WtpImg50, WtpImg51,
                WtpImg52, WtpImg53, WtpImg54, WtpImg55, WtpImg56, WtpImg57, WtpImg58, WtpImg59, WtpImg60 };
            images = imagesArr;
            itemManager = inputItemManager;
            words = itemManager.randomizeItemsInCategory(8).OrderBy(x => random.Next()).ToArray(); // randomize for 8 per category then randomize all
            WordLabel.Content = "Find Item: " + words[count].DisplayName;
            items = itemManager.randomizeItemsInCategory(10);
            setFigures();
            
            
        }

        private Item[] selectRandomWords(Item[] inputArr)
        {  
            return inputArr.OrderBy(x => random.Next()).ToArray();
        }

        private void imageMouseUp(object sender, RoutedEventArgs e)
        {
            // find the current image by comparing the sender object with all the images in the array until it's found
            if(currImg != null) 
                currImg.Opacity = 1;
            foreach ( Image img in images )
            {
                if (sender.Equals(img)) 
                { 
                    currImg = img;
                    break;
                }
            }
            currImg.Opacity = 0.6;
            WtpDisplayImg.Source = currImg.Source;
        }

        private void Word_To_Picture_Confirm_Button_Click(object sender, RoutedEventArgs e)
        {
            if (currImg != null) 
            {
                if (currImg.Tag.ToString() == words[count].Name)
                {
                    correctAmount++;
                }
                count++;
                if (count < 48)
                {
                    items = itemManager.randomizeItemsInCategory(10); 
                    setFigures();
                    WordLabel.Content = "Find Item: " + words[count].DisplayName;
                }
                else
                {
                    correctAmountArr[1] = correctAmount;
                    WordToPictureFrame.Content = new PictureSort(itemManager, correctAmountArr);
                }
            }
        }

        private void setFigures()
        {
            for (int i = 0; i < images.Length; i++)
            {
                images[i].Tag = items[i].Name; // set tags to use in conditional
                setFigure(items[i].Path, images[i]);
            }
        }

        private void setFigure(String path, Image image)
        {
            Uri resourceUri = new Uri("/img/" + path + ".jpg", UriKind.Relative);
            image.Source = new BitmapImage(resourceUri);
        }

        
    }
}
