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
        //public List<Pizza> choice = new List<Pizza>(); 

        public static List<string> choice = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            Pizza();
            //choice .Add(new Pizza { pizzaName  = "Margarita", price = "alm: 50, fam: 100" , indgredienser = "tomat, ost, origano"});
            //choice .Add(new Pizza { pizzaName  = "Dirty Joe's", price = "alm: 75, fam: 150",indgredienser = "tomat, ost, sardiner, bacon, sild, nutella, origano" });
            //choice.Add(new Pizza { pizzaName = "Skinke", price = "alm: 60, fam: 120", indgredienser = "tomat, ost, skinke, origano" });
            //choice.Add(new Pizza { pizzaName = "Byg selv", price = "alm: 80, fam: 160", indgredienser = "tomat, ost, skinke, +5 efter eget valg" });


       //     myComboBox.ItemsSource = choice;
        }

        //Denne void siger hvad der sker når man trykker på submit knappen
        //private void submitButton_Click(object sender, RoutedEventArgs e)
        //{
        //    //Denne textbox fortæller dig hvad for en slags pizza du har bestilt
        //    MessageBox.Show("Du vil gerne have en " + pizza.Text + " pizza");
        //}

        #region This works
        //Valg af pizza
        //public class Pizza
        //{

        //    public string pizzaName { get; set; }

        //    public string price { get; set; }

        //    public string indgredienser { get; set; }

        //    public string fullFizza
        //    {
        //        get
        //        {
        //            return pizzaName + " pizza " + price + " " + indgredienser;
        //        }
        //    }

        //}
        #endregion 

        public static void  Pizza ()
        {

           choice .Add( "Margarita alm: 50, fam: 100 indgredienser tomat, ost, origano");
           choice .Add( "Dirty Joe's alm: 75, fam: 150 indgredienser tomat, ost, sardiner, bacon, sild, nutella, origano" );
           choice.Add( "Skinke alm: 60, fam: 120 indgredienser tomat, ost, skinke, origano" );
           choice.Add("Byg selv alm: 80, fam: 160 indgredienser  tomat, ost, skinke, +5 efter eget valg" );

        }

        private void sizeNormal_Checked(object sender, RoutedEventArgs e)
        {
            this.sizeBig.IsChecked = false;
        }

        private void sizeBig_Checked(object sender, RoutedEventArgs e)
        {
            this.sizeNormal.IsChecked = false;
        }

        private void myComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.pris.Text = (string)((ComboBoxItem)((ComboBox)sender).SelectedValue).Content;

            
        }
    }
}
