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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ItemManager items;
        public MainWindow()
        {
            InitializeComponent();
            Item[] itemsDB = { new Item("Camel", "land-animal"), new Item("Cow", "land-animal"), new Item("Elephant", "land-animal"),
                new Item("Giraffe", "land-animal"), new Item("Gorilla", "land-animal"), new Item("Lion", "land-animal"),
                new Item("Panda", "land-animal"), new Item("Rhino", "land-animal"), new Item("Sheep", "land-animal"),
                new Item("Zebra", "land-animal"), new Item("Crow", "bird"), new Item("Eagle", "bird"), new Item("Flamingo", "bird"),
                new Item("Ostrich", "bird"), new Item("Owl", "bird"), new Item("Parrot", "bird"), new Item("Penguin", "bird"),
                new Item("Robin", "bird"), new Item("Seagull", "bird"), new Item("Toucan", "bird"), new Item("Apple", "fruit"),
                new Item("Banana", "fruit"), new Item("Kiwi", "fruit"), new Item("Lemon", "fruit"), new Item("Melon", "fruit"),
                new Item("Orange", "fruit"), new Item("Pear", "fruit"), new Item("Pineapple", "fruit"), new Item("Rasberry", "fruit"),
                new Item("Strawberry", "fruit"), new Item("Bed", "household-item"), new Item("Couch", "household-item"),
                new Item("Fridge", "household-item"), new Item("Iron", "household-item"), new Item("Kettle", "household-item"),
                new Item("Lamp", "household-item"), new Item("Tap", "household-item"), new Item("Telephone", "household-item"),
                new Item("Television", "household-item"), new Item("Towel", "household-item"), new Item("Chisel", "tool"),
                new Item("Hammer", "tool"), new Item("Mallet", "tool"), new Item("Measuring-Tape", "tool"),
                new Item("Pliers", "tool"), new Item("Power-Drill", "tool"), new Item("Saw", "tool"), new Item("Scissors", "tool"),
                new Item("Screwdriver", "tool"), new Item("Wrench", "tool"), new Item("Airplane", "vehicle"),
                new Item("Bicycle", "vehicle"), new Item("Boat", "vehicle"), new Item("Bus", "vehicle"),
                new Item("Car", "vehicle"), new Item("Helicopter", "vehicle"), new Item("Motorcycle", "vehicle"),
                new Item("Submarine", "vehicle"), new Item("Train", "vehicle"), new Item("Truck", "vehicle")};
            items = new ItemManager(itemsDB);
        }

        private void Begin_Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Naming(items);
        }

        private void Help_Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Help();
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

