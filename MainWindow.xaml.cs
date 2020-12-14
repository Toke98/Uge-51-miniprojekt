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

namespace Uge_51_miniprojekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Pizza> choice = new List<Pizza>(); 

        public MainWindow()
        {
            InitializeComponent();

            choice .Add(new Pizza { pizzaName  = "Margarita", price = "alm: 50, fam: 100" , indgredienser = "tomat, ost, origano"});
            choice .Add(new Pizza { pizzaName  = "Dirty Joe's", price = "alm: 75, fam: 150",indgredienser = "tomat, ost, sardiner, bacon, sild, nutella, origano" });
            choice .Add(new Pizza { pizzaName  = "Skinke" , price ="alm: 60, fam: 120", indgredienser = "tomat, ost, skinke, origano" });

            choice.ForEach(Console.WriteLine);

            myComboBox.ItemsSource = choice;
        }

        //Denne void siger hvad der sker når man trykker på submit knappen
        //private void submitButton_Click(object sender, RoutedEventArgs e)
        //{
        //    //Denne textbox fortæller dig hvad for en slags pizza du har bestilt
        //    MessageBox.Show("Du vil gerne have en " + pizza.Text + " pizza");
        //}

        //Valg af pizza
        public class Pizza
        {

            public string pizzaName { get; set; }

            public string price { get; set; }

            public string indgredienser { get; set; }

            public string fullFizza
            {
                get
                {
                    return pizzaName + " pizza " + price + " " + indgredienser;
                }
            }

        }
    }
}
