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
        // public List<Pizza> choice = new List<Pizza>(); 

        public static List<string> choice = new List<string>();
        public static int counter;
        public static double samletPris;
        public static double enkeltPris;

        public static int topings;
        public static bool extraOrNot = false;

        public MainWindow()
        {
            InitializeComponent();
            pris.Text = Convert.ToString(enkeltPris);
            {
                //choice .Add(new Pizza { pizzaName  = "Margarita", price = "alm: 50, fam: 100" , indgredienser = "tomat, ost, origano"});
                //choice .Add(new Pizza { pizzaName  = "Dirty Joe's", price = "alm: 75, fam: 150",indgredienser = "tomat, ost, sardiner, bacon, sild, nutella, origano" });
                //choice.Add(new Pizza { pizzaName = "Skinke", price = "alm: 60, fam: 120", indgredienser = "tomat, ost, skinke, origano" });
                //choice.Add(new Pizza { pizzaName = "Byg selv", price = "alm: 80, fam: 160", indgredienser = "tomat, ost, skinke, +5 efter eget valg" });


                //     myComboBox.ItemsSource = choice;
            }
        }


        ///Useless for nu
        #region Useless
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

        //Useless
        public static void Pizza()
        {
            //Useless
            {
                //choice .Add( "Margarita alm: 50, fam: 100 indgredienser tomat, ost, origano");
                //choice .Add( "Dirty Joe's alm: 75, fam: 150 indgredienser tomat, ost, sardiner, bacon, sild, nutella, origano" );
                //choice.Add( "Skinke alm: 60, fam: 120 indgredienser tomat, ost, skinke, origano" );
                //choice.Add("Byg selv alm: 80, fam: 160 indgredienser  tomat, ost, skinke, +5 efter eget valg" );
            }
        }
        #endregion 

        ///Størrelse
        #region Størrelse

        //If Normal Pizza
        private void sizeNormal_Checked(object sender, RoutedEventArgs e)
        {
            this.sizeBig.IsChecked = false;


                //Print på skærmen
                {
                    skinke.Content = "Skinke +5";
                    ost.Content = "Ost +5";
                    kastanjer.Content = "Kastanjer +5";
                    græskerKerner.Content = "Græsker kerner +5";
                    salat.Content = "Salat +10";
                    majs.Content = "Majs +5";
                    tun.Content = "Tun +5";
                }

            if (sizeBig.IsChecked == false && sizeNormal.IsChecked == false)
            {

                this.prisIAlt.Text = null;
            }

            pris.Text = Convert.ToString(enkeltPris);

        }

        //If big Pizza
        private void sizeBig_Checked(object sender, RoutedEventArgs e)
        {
            this.sizeNormal.IsChecked = false;

            
                //Tilbehør Stor
                {
                        //Print på skærm
                        skinke.Content = "Skinke +10";
                        ost.Content = "Ost +10";
                        kastanjer.Content = "Kastanjer +10";
                        græskerKerner.Content = "Græsker kerner +10";
                        salat.Content = "Salat +15";
                        majs.Content = "Majs +10";
                        tun.Content = "Tun +10";
                    
                }

            if (sizeBig.IsChecked == false && sizeNormal.IsChecked == false)
            {
                this.prisIAlt.Text = null;

            }

            pris.Text = Convert.ToString(enkeltPris);
        }
        #endregion 

        //What Pizza is selected
        private void myComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //  this.pris.Text = (string)((ComboBoxItem)((ComboBox)sender).SelectedValue).Content;
            // Byg Selv
            if (this.myComboBox.SelectedItem == bygSelv && 4 > counter)
            {
                skinke.Content = "Skinke";
                ost.Content = "Ost";
                kastanjer.Content = "Kastanjer";
                græskerKerner.Content = "Græsker kerner";
                salat.Content = "Salat";
                majs.Content = "Majs";
                tun.Content = "Tun";

                // Pris 0kr.
                if (sizeBig.IsChecked == true || sizeNormal.IsChecked == false)
                {
                    if (skinke.IsChecked == true)
                    {
                        samletPris += 0;
                        counter++;
                    }

                    if (tun.IsChecked == true)
                    {
                        samletPris += 0;
                        counter++;
                    }
                    if (græskerKerner.IsChecked == true)
                    {
                        samletPris += 0;
                        counter++;
                    }

                    if (majs.IsChecked == true)
                    {
                        counter++;
                        samletPris += 0;
                    }

                    if (kastanjer.IsChecked == true)
                    {
                        counter++;
                        samletPris += 0;
                    }

                    if (ost.IsChecked == true)
                    {
                        counter++;
                        samletPris += 0;
                    }

                    if (salat.IsChecked == true)
                    {
                        counter++;
                        samletPris += 0;
                    }
                }

                if (counter >= 4)
                {
                    //Tilbehør Stor
                    {
                        //Pris på tilbehør
                        {
                            if (sizeBig.IsChecked == true || sizeNormal.IsChecked == false)
                            {
                                if (skinke.IsChecked == true)
                                {
                                    samletPris += 10;
                                    counter++;
                                }

                                if (tun.IsChecked == true)
                                {
                                    samletPris += 10;
                                    counter++;
                                }
                                if (græskerKerner.IsChecked == true)
                                {
                                    samletPris += 10;
                                    counter++;
                                }

                                if (majs.IsChecked == true)
                                {
                                    counter++;
                                    samletPris += 10;
                                }

                                if (kastanjer.IsChecked == true)
                                {
                                    counter++;
                                    samletPris += 10;
                                }

                                if (ost.IsChecked == true)
                                {
                                    counter++;
                                    samletPris += 10;
                                }

                                if (salat.IsChecked == true)
                                {
                                    counter++;
                                    samletPris += 15;
                                }
                            }

                            //Print på skærm
                            skinke.Content = "Skinke +10";
                            ost.Content = "Ost +10";
                            kastanjer.Content = "Kastanjer +10";
                            græskerKerner.Content = "Græsker kerner +10";
                            salat.Content = "Salat +15";
                            majs.Content = "Majs +10";
                            tun.Content = "Tun +10";
                        }
                    }

                    //Tilbehør Normal
                    {
                        //Pris på tilbehør
                        {
                            if (sizeBig.IsChecked == false || sizeNormal.IsChecked == true)
                            {
                                if (skinke.IsChecked == true)
                                {
                                    samletPris += 5;
                                    counter++;
                                }

                                if (tun.IsChecked == true)
                                {
                                    samletPris += 5;
                                    counter++;
                                }
                                if (græskerKerner.IsChecked == true)
                                {
                                    samletPris += 5;
                                    counter++;
                                }

                                if (majs.IsChecked == true)
                                {
                                    counter++;
                                    samletPris += 5;
                                }

                                if (kastanjer.IsChecked == true)
                                {
                                    counter++;
                                    samletPris += 5;
                                }

                                if (ost.IsChecked == true)
                                {
                                    counter++;
                                    samletPris += 5;
                                }

                                if (salat.IsChecked == true)
                                {
                                    counter++;
                                    samletPris += 10;
                                }
                            }
                        }

                        //Print på skærmen
                        {
                            skinke.Content = "Skinke +5";
                            ost.Content = "Ost +5";
                            kastanjer.Content = "Kastanjer +5";
                            græskerKerner.Content = "Græsker kerner +5";
                            salat.Content = "Salat +10";
                            majs.Content = "Majs +5";
                            tun.Content = "Tun +5";
                        }
                    }
                }

            }
            enkeltPris = samletPris;
            pris.Text = Convert.ToString(enkeltPris);

            //Hvis du vil have en pizza
            if (this.myComboBox.SelectedItem != pepsi || this.myComboBox.SelectedItem != fanta || this.myComboBox.SelectedItem != sprite || this.myComboBox.SelectedItem != drikke)
            {
                //Ekstra tilbehør
                {
                    skinke.Visibility = Visibility.Visible;
                    ost.Visibility = Visibility.Visible;
                    salat.Visibility = Visibility.Visible;
                    kastanjer.Visibility = Visibility.Visible;
                    tun.Visibility = Visibility.Visible;
                    majs.Visibility = Visibility.Visible;
                    hvidløg.Visibility = Visibility.Visible;
                    græskerKerner.Visibility = Visibility.Visible;
                }

                //Størrelse
                {
                    //Pizza
                    sizeBig.Visibility = Visibility.Visible;
                    sizeNormal.Visibility = Visibility.Visible;

                    //Soda
                    sodaSizeSmall.Visibility = Visibility.Hidden;
                    sodaSizeNormal.Visibility = Visibility.Hidden;
                    sodaSizeBig.Visibility = Visibility.Hidden;
                }

                add.Content = "Add Pizza";
            }

            //Drikkevare har ikke tilbehør
            if (this.myComboBox.SelectedItem == pepsi || this.myComboBox.SelectedItem == fanta || this.myComboBox.SelectedItem == sprite || this.myComboBox.SelectedItem == drikke)
            {
                //Ekstra tilbehør
                {
                    skinke.Visibility = Visibility.Hidden;
                    ost.Visibility = Visibility.Hidden;
                    salat.Visibility = Visibility.Hidden;
                    kastanjer.Visibility = Visibility.Hidden;
                    tun.Visibility = Visibility.Hidden;
                    majs.Visibility = Visibility.Hidden;
                    hvidløg.Visibility = Visibility.Hidden;
                    græskerKerner.Visibility = Visibility.Hidden;
                }

                //Størrelse
                {
                    //Pizza
                    sizeBig.Visibility = Visibility.Hidden;
                    sizeNormal.Visibility = Visibility.Hidden;

                    //Soda
                    sodaSizeSmall.Visibility = Visibility.Visible;
                    sodaSizeNormal.Visibility = Visibility.Visible;
                    sodaSizeBig.Visibility = Visibility.Visible;
                }

                add.Content = "Add Soda";
            }
        }


        ///Knapper
        #region Knapper

        //Samlet pris og tilføjelse af pizza
        private void add_Click(object sender, RoutedEventArgs e)
        {
            //Ubeslutsomhed
            {
                if (this.myComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Du har ikke valgt en pizza eller sodavand");
                }

                if (sizeBig.IsChecked == false && sizeNormal.IsChecked == false && sodaSizeBig.IsChecked == false && sodaSizeNormal.IsChecked == false && sodaSizeSmall.IsChecked == false)
                {
                    MessageBox.Show("Du har ikke valgt en størrelse");
                }

            }

            //Størrelse på pizza
            {
                //Normal Pizza
                if (sizeNormal.IsChecked == true)
                {
                    if (this.myComboBox.SelectedItem == marg)
                    {
                        samletPris += 50;
                        liste.Text += "Margarita";
                    }

                    if (this.myComboBox.SelectedItem == dirtyJoe)
                    {
                        samletPris += 75;
                        liste.Text += "Dirty Joe";
                    }

                    if (this.myComboBox.SelectedItem == skinkePizza)
                    {
                        samletPris += 60;
                        liste.Text += "Skinke pizza";
                    }

                    if (this.myComboBox.SelectedItem == bygSelv)
                    {
                        samletPris += 70;
                        liste.Text += "Byg selv";
                    }
                }

                //Stor Pizza
                if (sizeBig.IsChecked == true)
                {
                    if (this.myComboBox.SelectedItem == marg)
                    {
                        samletPris += 100;
                        liste.Text += "Margarita";
                    }

                    if (this.myComboBox.SelectedItem == dirtyJoe)
                    {
                        samletPris += 150;
                        liste.Text += "Dirty Joe";
                    }

                    if (this.myComboBox.SelectedItem == skinkePizza)
                    {
                        samletPris += 120;
                        liste.Text += "Skinke pizza";
                    }

                    if (this.myComboBox.SelectedItem == bygSelv)
                    {
                        samletPris += 140;
                        liste.Text += "Byg selv";
                    }
                }
            }

            //Hvis der er tilføget noget
            if (extraOrNot ==true)
            {
                liste.Text += ", Ekstra: ";
            }

            //Soda
            if (this.myComboBox.SelectedItem == pepsi || this.myComboBox.SelectedItem == fanta || this.myComboBox.SelectedItem == sprite)
            {
                //Valgt sodavan
                {
                    if (this.myComboBox.SelectedItem == pepsi)
                    {
                        liste.Text += "Pepsi: ";
                    }

                    if (this.myComboBox.SelectedItem == fanta)
                    {
                        liste.Text += "Fanta: ";
                    }

                    if (this.myComboBox.SelectedItem == sprite)
                    {
                        liste.Text += "Sprite: ";
                    }
                }

                //Valgt størrelse
                {
                    if (sodaSizeSmall.IsChecked == true)
                    {
                        samletPris += 15;
                        liste.Text  += "lille 33cl";
                    }

                    if (sodaSizeNormal.IsChecked == true)
                    {
                        samletPris += 25;
                        liste.Text += "mellem 500ml";
                    }

                    if (sodaSizeBig.IsChecked == true)
                    {
                        samletPris += 40;
                        liste.Text += "stor 1,5l";
                    }
                }
            }

            ///Tilbehør
            {
                //Pris på tilbehør, hvis normal
                {
                    counter = 0;
                    //normal
                    {
                        if (sizeBig.IsChecked == false || sizeNormal.IsChecked == true)
                        {
                            if (skinke.IsChecked == true)
                            {
                                topings--;
                                samletPris += 5;
                                liste.Text += "skinke";
                                if (0 < topings)
                                {
                                    liste.Text += ", ";
                                }
                            }

                            if (tun.IsChecked == true)
                            {
                                topings--;
                                samletPris += 5;
                                liste.Text += "tun";
                                if (0 < topings)
                                {
                                    liste.Text += ", ";
                                }
                            }

                            if (græskerKerner.IsChecked == true)
                            {
                                topings--;
                                samletPris += 5;
                                liste.Text += "græskarkerner";
                                if (0 < topings)
                                {
                                    liste.Text += ", ";
                                }
                            }

                            if (majs.IsChecked == true)
                            {
                                topings--;
                                samletPris += 5;
                                liste.Text += "majs";
                                if (0 < topings)
                                {
                                    liste.Text += ", ";
                                }
                            }

                            if (kastanjer.IsChecked == true)
                            {
                                topings--;
                                samletPris += 5;
                                liste.Text += "kastanjer";
                                if (0 < topings)
                                {
                                    liste.Text += ", ";
                                }
                            }

                            if (ost.IsChecked == true)
                            {
                                topings--;
                                samletPris += 5;
                                liste.Text += "ekstra ost";
                                if (0 < topings)
                                {
                                    liste.Text += ", ";
                                }
                            }

                            if (salat.IsChecked == true)
                            {
                                topings--;
                                samletPris += 10;
                                liste.Text += "salat";
                                if (0 < topings)
                                {
                                    liste.Text += ", ";
                                }
                            }
                        }
                    }


                    //Print på skærmen
                    {
                        skinke.Content = "Skinke +5";
                        ost.Content = "Ost +5";
                        kastanjer.Content = "Kastanjer +5";
                        græskerKerner.Content = "Græsker kerner +5";
                        salat.Content = "Salat +10";
                        majs.Content = "Majs +5";
                        tun.Content = "Tun +5";
                    }
                }

                //Pris på tilbehør, hvis stor
                {

                    //Tilbehør Stor
                    {
                        //Pris på tilbehør
                        {
                            if (sizeBig.IsChecked == true || sizeNormal.IsChecked == false)
                            {
                                if (skinke.IsChecked == true)
                                {
                                    topings--;
                                    samletPris += 10;
                                    liste.Text += "skinke";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }

                                if (tun.IsChecked == true)
                                {
                                    topings--;
                                    samletPris += 10;
                                    liste.Text += "tun";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }

                                if (græskerKerner.IsChecked == true)
                                {
                                    topings--;
                                    samletPris += 10;
                                    liste.Text += "græskarkerner";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }

                                if (majs.IsChecked == true)
                                {
                                    topings--;
                                    samletPris += 10;
                                    liste.Text += "majs";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }

                                if (kastanjer.IsChecked == true)
                                {
                                    topings--;
                                    samletPris += 10;
                                    liste.Text += "kastanjer";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }

                                if (ost.IsChecked == true)
                                {
                                    topings--;
                                    samletPris += 10;
                                    liste.Text += "ekstra ost";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }

                                if (salat.IsChecked == true)
                                {
                                    topings--;
                                    samletPris += 15;
                                    liste.Text += "salat";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }
                            }

                            //Print på skærm
                            skinke.Content = "Skinke +10";
                            ost.Content = "Ost +10";
                            kastanjer.Content = "Kastanjer +10";
                            græskerKerner.Content = "Græsker kerner +10";
                            salat.Content = "Salat +15";
                            majs.Content = "Majs +10";
                            tun.Content = "Tun +10";

                        }
                    }
                }
            }

            liste.Text += " - " + Convert.ToString(enkeltPris)+"kr.";
            counter = 0;
            enkeltPris = 0;
            pris.Text = null;
            prisIAlt.Text = Convert.ToString(samletPris);
            liste.Text += Environment.NewLine;

            //Størrelser
            {
                sizeBig.IsChecked = false;
                sizeNormal.IsChecked = false;
                sodaSizeNormal.IsChecked = false;
                sodaSizeBig.IsChecked = false;
                sodaSizeSmall.IsChecked = false;
            }

            //Tilbehør
            {
                ost.IsChecked = false;
                skinke.IsChecked = false;
                salat.IsChecked = false;
                tun.IsChecked = false;
                majs.IsChecked = false;
                kastanjer.IsChecked = false;
                græskerKerner.IsChecked = false;
                hvidløg.IsChecked = false;
            }

        }

        //Reset knap
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            samletPris = 0;
            prisIAlt.Text = null;
            pris.Text = null;
            counter = 0;

            ost.IsChecked = false;
            skinke.IsChecked = false;
            salat.IsChecked = false;
            tun.IsChecked = false;
            majs.IsChecked = false;
            kastanjer.IsChecked = false;
            græskerKerner.IsChecked = false;
            hvidløg.IsChecked = false;
            liste.Text = null;

            this.myComboBox.SelectedIndex = -1;
        }
        #endregion

        //Soda checks
        #region soda
        private void sodaSizeBig_Checked(object sender, RoutedEventArgs e)
        {
            sodaSizeNormal.IsChecked = false;
            sodaSizeSmall.IsChecked = false;
        }

        private void sodaSizeNormal_Checked(object sender, RoutedEventArgs e)
        {
            sodaSizeSmall.IsChecked = false;
            sodaSizeBig.IsChecked = false;
        }

        private void sodaSizeSmall_Checked(object sender, RoutedEventArgs e)
        {
            sodaSizeNormal.IsChecked = false;
            sodaSizeBig.IsChecked = false;
        }
        #endregion 

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            enkeltPris = 0;

            
            //Pizza
            {
                //Normal Pizza
                if (sizeNormal.IsChecked == true)
                {
                    if (this.myComboBox.SelectedItem == marg)
                    {
                        enkeltPris += 50;
                    }

                    if (this.myComboBox.SelectedItem == dirtyJoe)
                    {
                        enkeltPris += 75;
                    }

                    if (this.myComboBox.SelectedItem == skinkePizza)
                    {
                        enkeltPris += 60;
                    }

                    if (this.myComboBox.SelectedItem == bygSelv)
                    {
                        enkeltPris += 70;
                    }
                }

                //Stor Pizza
                if (sizeBig.IsChecked == true)
                {
                    if (this.myComboBox.SelectedItem == marg)
                    {
                        enkeltPris += 100;
                    }

                    if (this.myComboBox.SelectedItem == dirtyJoe)
                    {
                        enkeltPris += 150;
                    }

                    if (this.myComboBox.SelectedItem == skinkePizza)
                    {
                        enkeltPris += 120;
                    }

                    if (this.myComboBox.SelectedItem == bygSelv)
                    {
                        enkeltPris += 140;
                    }
                }
            }

            ///Tilbehør
            {
                //Er der ekstra
                {
                    if (skinke.IsChecked == true || hvidløg .IsChecked == true || græskerKerner .IsChecked == true || salat .IsChecked == true || kastanjer .IsChecked == true || ost .IsChecked == true || tun .IsChecked == true || majs .IsChecked == true )
                    {
                        extraOrNot = true;
                    }

                    //Hvor meget ekstra er der
                    {
                        topings = 0;
                        if (skinke.IsChecked == true)
                        {
                            topings++;
                        }

                        if (tun.IsChecked == true)
                        {
                            topings++;
                        }

                        if (græskerKerner.IsChecked == true)
                        {
                           topings++;
                        }

                        if (majs.IsChecked == true)
                        {
                           topings++;
                        }

                        if (kastanjer.IsChecked == true)
                        {
                            topings++;
                        }

                        if (ost.IsChecked == true)
                        {
                            topings++;
                        }

                        if (salat.IsChecked == true)
                        {
                            topings++;
                        }
                    }

                    if (skinke.IsChecked == false && hvidløg.IsChecked == false && græskerKerner.IsChecked == false && salat.IsChecked == false && kastanjer.IsChecked == false && ost.IsChecked == false && tun.IsChecked == false && majs.IsChecked == false)
                    {
                        extraOrNot = false;
                    }
                }

                //Normal slags pizza
                if (this.myComboBox.SelectedItem != bygSelv || counter >4)
                {
                    //normal
                    {
                        if (sizeBig.IsChecked == false || sizeNormal.IsChecked == true)
                        {
                            if (skinke.IsChecked == true)
                            {
                                enkeltPris += 5;
                            }

                            if (tun.IsChecked == true)
                            {
                                enkeltPris += 5;
                            }
                            if (græskerKerner.IsChecked == true)
                            {
                                enkeltPris += 5;
                            }

                            if (majs.IsChecked == true)
                            {
                                enkeltPris += 5;
                            }

                            if (kastanjer.IsChecked == true)
                            {
                                enkeltPris += 5;
                            }

                            if (ost.IsChecked == true)
                            {
                                enkeltPris += 5;
                            }

                            if (salat.IsChecked == true)
                            {
                                enkeltPris += 10;
                            }
                        }
                    }

                    //Tilbehør Stor
                    {
                        if (sizeBig.IsChecked == true || sizeNormal.IsChecked == false)
                        {
                            if (skinke.IsChecked == true)
                            {
                                enkeltPris += 10;

                            }

                            if (tun.IsChecked == true)
                            {
                                enkeltPris += 10;
                            }

                            if (græskerKerner.IsChecked == true)
                            {
                                enkeltPris += 10;
                            }

                            if (majs.IsChecked == true)
                            {
                                enkeltPris += 10;
                            }

                            if (kastanjer.IsChecked == true)
                            {
                                enkeltPris += 10;
                            }

                            if (ost.IsChecked == true)
                            {
                                enkeltPris += 10;
                            }

                            if (salat.IsChecked == true)
                            {
                                enkeltPris += 15;
                            }
                        }
                    }
                }

            }

            //Soda
            {
                if (this.myComboBox.SelectedItem == pepsi || this.myComboBox.SelectedItem == fanta || this.myComboBox.SelectedItem == sprite)
                {
                    enkeltPris = 0;
                    if (sodaSizeSmall.IsChecked == true)
                    {
                        enkeltPris += 15;
                    }

                    if (sodaSizeNormal.IsChecked == true)
                    {
                        enkeltPris += 25;
                    }

                    if (sodaSizeBig.IsChecked == true)
                    {
                       enkeltPris  += 40;
                    }
                }
            }

            pris.Text = Convert.ToString(enkeltPris);
        }
    }
}
