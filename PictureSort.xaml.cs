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
    /// Interaction logic for PictureSort.xaml
    /// </summary>
    public partial class PictureSort : Page
    {
        ItemManager itemManager;
        Item[] items;
        CheckBox[] checkboxes;
        int count = 0, correctAmount = 0, stage = 1;
        Dictionary<int, string[]> stageCategories = new Dictionary<int, string[]> { { 1,new string[]{"Manmade", "Nautural" } },
            { 2, new string[] { "Bird", "Fruit", "Household Item", "Land Animal", "Tool", "Vehicle" } } };
        int[] correctAmountArr;
        public PictureSort(ItemManager inputItemManager, int[] inputCorrectAmountArr)
        {
            InitializeComponent();
            correctAmountArr = inputCorrectAmountArr;
            setCategories();
            itemManager = inputItemManager;
            CheckBox[] checkboxesArr = { checkboxA, checkboxB, checkboxC, checkboxD, checkboxE, checkboxF };
            checkboxes = checkboxesArr;
            items = itemManager.randomizeItems();
            setFigure(items[0].Path, PictureSortImg);
        }

        private void setCategories()
        {
            switch (stage)
            {
                case 1:
                    {
                        checkboxA.Content = "Manmade";
                        checkboxB.Content = "Natural";
                        checkboxC.Visibility = Visibility.Hidden;
                        checkboxD.Visibility = Visibility.Hidden;
                        checkboxE.Visibility = Visibility.Hidden;
                        checkboxF.Visibility = Visibility.Hidden;
                        break;
                    }
                case 2:
                    {
                        checkboxA.Content = "Bird";
                        checkboxA.IsChecked = false;
                        checkboxB.Content = "Fruit";
                        checkboxB.IsChecked = false;
                        checkboxC.Content = "Household Item";
                        checkboxC.Visibility = Visibility.Visible;
                        checkboxD.Content = "Land Animal";
                        checkboxD.Visibility = Visibility.Visible;
                        checkboxE.Content = "Tool";
                        checkboxE.Visibility = Visibility.Visible;
                        checkboxF.Content = "Vehicle";
                        checkboxF.Visibility = Visibility.Visible;
                        break;
                    }
            }
        }

        private void setFigure(String path, Image image)
        {
            Uri resourceUri = new Uri("/img/" + path + ".jpg", UriKind.Relative);
            image.Source = new BitmapImage(resourceUri);
        }

        private void Picture_Sort_Button_Click(object sender, RoutedEventArgs e)
        {

            if (checkboxA.IsChecked == true)
            {
                correctAnswerSubroutine(stageCategories[stage][0]);
            }
            else if (checkboxB.IsChecked == true)
            {
                correctAnswerSubroutine(stageCategories[stage][1]);
            }
            else if (checkboxC.IsChecked == true)
            {
                correctAnswerSubroutine(stageCategories[stage][2]);
            }
            else if (checkboxD.IsChecked == true)
            {
                correctAnswerSubroutine(stageCategories[stage][3]);
            }
            else if (checkboxE.IsChecked == true)
            {
                correctAnswerSubroutine(stageCategories[stage][4]);
            }
            else if (checkboxF.IsChecked == true)
            {
                correctAnswerSubroutine(stageCategories[stage][5]);
            }
            else
            {
                errorLabel.Content = "no category selected";
            }
            
        }

        private void correctAnswerSubroutine(string tag)
        {
            errorLabel.Content = "";
            if (tag == getCategory(items[count]))
            {
                correctAmount++;
            }
            count++;
            if (count < 60)
            {
                setFigure(items[count].Path, PictureSortImg);
            }
            else
            {
                stage++;
                if (stage > 2)
                {
                    correctAmountArr[2] = correctAmount;
                    PictureSortFrame.Content = new WordSort(itemManager, correctAmountArr);
                }
                else
                {
                    count = 0;
                    items = itemManager.randomizeItems();
                    setFigure(items[count].Path, PictureSortImg);
                    setCategories();
                }
            }
        }

        private string getCategory(Item item)
        {
            switch (item.Category)
            {
                case "bird":
                    {
                        if (stage == 1) { return "Natural"; }
                        else { return "Bird"; }
                    }
                case "fruit":
                    {
                        if (stage == 1) { return "Natural"; }
                        else { return "Fruit"; }
                    }
                case "land animal":
                    {
                        if (stage == 1) { return "Natural"; }
                        else { return "Land Animal"; }
                    }
                case "household item":
                    {
                        if (stage == 1) { return "Manmade"; }
                        else { return "Household Item"; }
                    }
                case "tool":
                    {
                        if (stage == 1) { return "Manmade"; }
                        else { return "Tool"; }
                    }
                case "vehicle":
                    {
                        if (stage == 1) { return "Manmade"; }
                        else { return "Vehicle"; }
                    }
            }
            return "";
        }

        private void deselectCheckboxes(int senderIndex)
        {
            CheckBox sender = checkboxes[senderIndex];
            foreach (CheckBox checkbox in checkboxes)
            {
                if (checkbox != sender)
                {
                    checkbox.IsChecked = false;
                }
            }
        }

        private void CheckBox_Checked_A(object sender, RoutedEventArgs e)
        {
            deselectCheckboxes(0);
        }

        private void CheckBox_Checked_B(object sender, RoutedEventArgs e)
        {
            deselectCheckboxes(1);
        }

        private void CheckBox_Checked_C(object sender, RoutedEventArgs e)
        {
            deselectCheckboxes(2);
        }

        private void CheckBox_Checked_D(object sender, RoutedEventArgs e)
        {
            deselectCheckboxes(3);
        }

        private void CheckBox_Checked_E(object sender, RoutedEventArgs e)
        {
            deselectCheckboxes(4);
        }

        private void CheckBox_Checked_F(object sender, RoutedEventArgs e)
        {
            deselectCheckboxes(5);
        }
    }
}

