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
        //Public statements
        #region var table
        public static bool pizzaOrNot = false;
        public static bool bygselvOrNot = false;
        public static bool rabatBrugt = false;
        public static bool bigOrNot = false;
        public static bool extraOrNot = false;
        public static bool ubeslutsom = false;

        public static double samletPris;
        public static double enkeltPris;

        public static int counter;
        public static int pizzaCounter;
        public static int sodaCounter;
        public static int bygSelvCounter;
        public static int topings;
        public static int rabatPris = 0;
        #endregion 

        public MainWindow()
        {
            InitializeComponent();
            this.myComboBox.SelectedIndex = 0;
        }

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

        //Hvilken pizza er valgt
        private void myComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Hvis du vil have en pizza
            if (this.myComboBox.SelectedItem != pepsi || this.myComboBox.SelectedItem != fanta || this.myComboBox.SelectedItem != sprite || this.myComboBox.SelectedItem != drikkePrint)
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

                    sizeBig.IsChecked = false;
                    sizeNormal.IsChecked = false;
                    sodaSizeNormal.IsChecked = false;
                    sodaSizeBig.IsChecked = false;
                    sodaSizeSmall.IsChecked = false;
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
            if (this.myComboBox.SelectedItem == pepsi || this.myComboBox.SelectedItem == fanta || this.myComboBox.SelectedItem == sprite || this.myComboBox.SelectedItem == drikkePrint)
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

                    ost.IsChecked = false;
                    skinke.IsChecked = false;
                    salat.IsChecked = false;
                    tun.IsChecked = false;
                    majs.IsChecked = false;
                    kastanjer.IsChecked = false;
                    græskerKerner.IsChecked = false;
                    hvidløg.IsChecked = false;
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

            PrisCalc();
        }


        ///Knapper
        #region Knapper

        //Samlet pris og tilføjelse af pizza
        private void add_Click(object sender, RoutedEventArgs e)
        {
            //Ubeslutsomhed
            {
                if (this.myComboBox.SelectedItem == pizzaPrint || this.myComboBox.SelectedItem == drikkePrint)
                {
                    MessageBox.Show("Du har ikke valgt en pizza eller sodavand");
                    ubeslutsom = true;
                }

                if (sizeBig.IsChecked == false && sizeNormal.IsChecked == false && sodaSizeBig.IsChecked == false && sodaSizeNormal.IsChecked == false && sodaSizeSmall.IsChecked == false)
                {
                    MessageBox.Show("Du har ikke valgt en størrelse");
                    ubeslutsom = true;
                }

            }

            //Tilføjelse af vare
            if (ubeslutsom == false)
            {
                Indkøbsliste();

                //Samlet pris
                samletPris += enkeltPris;
                prisIAlt.Text = Convert.ToString(samletPris);

                //Rabat
                RabatCheck();
                PizzaOrSoda();
            }

            //Reset
            AddReset();
        }

        //Viser hvad du har købt
        private void Indkøbsliste()
        {
            // Indkøbsliste
            {
                if ((this.myComboBox.SelectedItem != pizzaPrint && this.myComboBox.SelectedItem != drikkePrint) && (sizeBig.IsChecked == true || sizeNormal.IsChecked == true || sodaSizeBig.IsChecked == true || sodaSizeSmall.IsChecked == true || sodaSizeNormal.IsChecked == true))
                {
                    ///Pizza
                    {
                        //Størrelse
                        {
                            //Stor Pizza
                            if (sizeBig.IsChecked == true)
                            {
                                if (this.myComboBox.SelectedItem == marg)
                                {
                                    liste.Text += "Margarita";
                                }

                                if (this.myComboBox.SelectedItem == dirtyJoe)
                                {
                                    liste.Text += "Dirty Joe";
                                }

                                if (this.myComboBox.SelectedItem == skinkePizza)
                                {
                                    liste.Text += "Skinke pizza";
                                }

                                if (this.myComboBox.SelectedItem == bygSelv)
                                {
                                    liste.Text += "Byg selv";
                                }
                            }

                            //Normal Pizza
                            if (sizeNormal.IsChecked == true)
                            {
                                if (this.myComboBox.SelectedItem == marg)
                                {
                                    liste.Text += "Margarita";
                                }

                                if (this.myComboBox.SelectedItem == dirtyJoe)
                                {
                                    liste.Text += "Dirty Joe";
                                }

                                if (this.myComboBox.SelectedItem == skinkePizza)
                                {
                                    liste.Text += "Skinke pizza";
                                }

                                if (this.myComboBox.SelectedItem == bygSelv)
                                {
                                    liste.Text += "Byg selv";
                                }
                            }
                        }

                        //Hvis der er tilføget noget
                        if (extraOrNot == true)
                        {
                            liste.Text += ", Ekstra: ";
                        }
                    }

                    //Soda
                    if (this.myComboBox.SelectedItem == pepsi || this.myComboBox.SelectedItem == fanta || this.myComboBox.SelectedItem == sprite)
                    {
                        //Valgt sodavand
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
                                liste.Text += "lille 33cl";
                            }

                            if (sodaSizeNormal.IsChecked == true)
                            {
                                liste.Text += "mellem 500ml";
                            }

                            if (sodaSizeBig.IsChecked == true)
                            {
                                liste.Text += "stor 1,5l";
                            }
                        }
                    }

                    ///Tilbehør
                    {
                        counter = 0;
                        //normal
                        {
                            if (sizeBig.IsChecked == false || sizeNormal.IsChecked == true)
                            {
                                if (skinke.IsChecked == true)
                                {
                                    topings--;
                                    liste.Text += "skinke";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }

                                if (tun.IsChecked == true)
                                {
                                    topings--;
                                    liste.Text += "tun";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }

                                if (græskerKerner.IsChecked == true)
                                {
                                    topings--;
                                    liste.Text += "græskarkerner";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }

                                if (majs.IsChecked == true)
                                {
                                    topings--;
                                    liste.Text += "majs";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }

                                if (kastanjer.IsChecked == true)
                                {
                                    topings--;
                                    liste.Text += "kastanjer";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }

                                if (ost.IsChecked == true)
                                {
                                    topings--;
                                    liste.Text += "ekstra ost";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }

                                if (salat.IsChecked == true)
                                {
                                    topings--;
                                    liste.Text += "salat";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }
                            }
                        }


                        //Tilbehør Stor
                        {
                            if (sizeBig.IsChecked == true || sizeNormal.IsChecked == false)
                            {
                                if (skinke.IsChecked == true)
                                {
                                    topings--;
                                    liste.Text += "skinke";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }

                                if (tun.IsChecked == true)
                                {
                                    topings--;
                                    liste.Text += "tun";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }

                                if (græskerKerner.IsChecked == true)
                                {
                                    topings--;
                                    liste.Text += "græskarkerner";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }

                                if (majs.IsChecked == true)
                                {
                                    topings--;
                                    liste.Text += "majs";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }

                                if (kastanjer.IsChecked == true)
                                {
                                    topings--;
                                    liste.Text += "kastanjer";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }

                                if (ost.IsChecked == true)
                                {
                                    topings--;
                                    liste.Text += "ekstra ost";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }

                                if (salat.IsChecked == true)
                                {
                                    topings--;
                                    liste.Text += "salat";
                                    if (0 < topings)
                                    {
                                        liste.Text += ", ";
                                    }
                                }
                            }
                        }
                    }

                    liste.Text += " - " + Convert.ToString(enkeltPris) + "kr.";

                    //Prisudregning
                    {
                        PrisCalc();

                        prisIAlt.Text = Convert.ToString(samletPris);
                        liste.Text += Environment.NewLine;
                    }
                }
            }
        }

        //Reset knap
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            samletPris = 0;
            prisIAlt.Text = null;
            pris.Text = null;
            counter = 0;

            //Rabat reset
            {
                rabat.Visibility = Visibility.Hidden;
                rabatTag.Visibility = Visibility.Hidden;
                rabatBrugt = false;
                rabatPris = 0;
                pizzaCounter = 0;
                sodaCounter = 0;
                bigOrNot = false;
                pizzaOrNot = false;
            }

            //Tilbehørs reset
            {
                bygSelvCounter = 0;
                bygselvOrNot = false;
                ost.IsChecked = false;
                skinke.IsChecked = false;
                salat.IsChecked = false;
                tun.IsChecked = false;
                majs.IsChecked = false;
                kastanjer.IsChecked = false;
                græskerKerner.IsChecked = false;
                hvidløg.IsChecked = false;
                liste.Text = null;
            }
            this.myComboBox.SelectedIndex = 0;
        }
        #endregion

        //Reseter det nødvændige efter at have tilføjet noget til kurven
        private void AddReset()
        {
            counter = 0;
            enkeltPris = 0;
            bygSelvCounter = 0;

            pris.Text = null;

            bygselvOrNot = false;
            ubeslutsom = false;
            pizzaOrNot = false;

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

        /// Sikre sig at du kun kan vælge èn størrelse
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

        //Opdatere enkelt prisen hver gang du klikker på tilbehør
        private void Check_Click(object sender, RoutedEventArgs e)
        {
            PrisCalc();
        }

        /// Rabat relateret
        #region Rabat
        //Tjekker rabatten
        public void RabatCheck()
        {
            //Rabat
            if (pizzaCounter > 1 && sodaCounter > 1)
            {
                samletPris += rabatPris;
                rabat.Visibility = Visibility.Visible;
                rabatTag.Visibility = Visibility.Visible;

                if (bigOrNot == true)
                {
                    rabat.Text = Convert.ToString(10);
                    rabatPris = 10;
                }

                if (bigOrNot == false)
                {
                    rabat.Text = Convert.ToString(5);
                    rabatPris = 5;
                }
                samletPris -= rabatPris;
            }

            //Fratrækker rabat
            if (rabatBrugt == false )
            {
                if (rabatPris >0)
                {
                    rabatBrugt = true ;
                }
            }
        }

        //Hjælper rabatten til at finde ud af om du har rabat eller ej
        public void PizzaOrSoda()
        {
            if (this.myComboBox.SelectedItem == marg || this.myComboBox.SelectedItem == dirtyJoe || this.myComboBox.SelectedItem == skinkePizza || this.myComboBox.SelectedItem == bygSelv)
            {
                pizzaCounter++;
                pizzaOrNot = true;
                
                if (this.sizeBig.IsChecked == true)
                {
                    bigOrNot = true;
                }

                if (this.sizeNormal.IsChecked == true)
                {
                    bigOrNot = false;
                }
            }

            if (this.myComboBox.SelectedItem == pepsi || this.myComboBox.SelectedItem == fanta || this.myComboBox.SelectedItem == sprite)
            {
                pizzaOrNot = false;
                sodaCounter++;
            }
        }
        #endregion 

        //Udregner enkelt prisen
        public void PrisCalc()
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
                        if (skinke.IsChecked == true || hvidløg.IsChecked == true || græskerKerner.IsChecked == true || salat.IsChecked == true || kastanjer.IsChecked == true || ost.IsChecked == true || tun.IsChecked == true || majs.IsChecked == true)
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


                    //Bygselv pizza
                    if (this.myComboBox.SelectedItem == bygSelv && bygSelvCounter <= 4)
                    {
                        bygselvOrNot = true;
                        //normal
                        {
                            if (sizeBig.IsChecked == false && sizeNormal.IsChecked == true)
                            {
                                bygSelvCounter = 0;
                                if (skinke.IsChecked == true && bygSelvCounter < 4)
                                {
                                    bygSelvCounter++;
                                    enkeltPris -= 5;
                                }

                                if (tun.IsChecked == true && bygSelvCounter < 4)
                                {
                                    bygSelvCounter++;
                                    enkeltPris -= 5;
                                }

                                if (græskerKerner.IsChecked == true && bygSelvCounter < 4)
                                {
                                    bygSelvCounter++;
                                    enkeltPris -= 5;
                                }

                                if (majs.IsChecked == true && bygSelvCounter < 4)
                                {
                                    bygSelvCounter++;
                                    enkeltPris -= 5;
                                }

                                if (kastanjer.IsChecked == true && bygSelvCounter < 4)
                                {
                                    bygSelvCounter++;
                                    enkeltPris -= 5;
                                }

                                if (ost.IsChecked == true && bygSelvCounter < 4)
                                {
                                    bygSelvCounter++;
                                    enkeltPris -= 5;
                                }

                                if (salat.IsChecked == true && bygSelvCounter < 4)
                                {
                                    bygSelvCounter++;
                                    enkeltPris -= 10;
                                }
                            }
                        }

                        //Tilbehør Stor
                        {
                            if (sizeBig.IsChecked == true && sizeNormal.IsChecked == false)
                            {
                                bygSelvCounter = 0;
                                if (skinke.IsChecked == true && bygSelvCounter < 4)
                                {
                                    bygSelvCounter++;
                                    enkeltPris -= 10;
                                }

                                if (tun.IsChecked == true && bygSelvCounter < 4)
                                {
                                    bygSelvCounter++;
                                    enkeltPris -= 10;
                                }

                                if (græskerKerner.IsChecked == true && bygSelvCounter < 4)
                                {
                                    bygSelvCounter++;
                                    enkeltPris -= 10;
                                }

                                if (majs.IsChecked == true && bygSelvCounter < 4)
                                {
                                    bygSelvCounter++;
                                    enkeltPris -= 10;
                                }

                                if (kastanjer.IsChecked == true && bygSelvCounter < 4)
                                {
                                    bygSelvCounter++;
                                    enkeltPris -= 10;
                                }

                                if (ost.IsChecked == true && bygSelvCounter < 4)
                                {
                                    bygSelvCounter++;
                                    enkeltPris -= 10;
                                }

                                if (salat.IsChecked == true && bygSelvCounter < 4)
                                {
                                    bygSelvCounter++;
                                    enkeltPris -= 15;
                                }
                            }
                        }
                    }

                    //Normal slags pizza
                    {
                        //normal
                        {
                            if (sizeBig.IsChecked == false && sizeNormal.IsChecked == true)
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
                            if (sizeBig.IsChecked == true && sizeNormal.IsChecked == false)
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
                            enkeltPris += 40;
                        }
                    }
                }

                pris.Text = Convert.ToString(enkeltPris);
        }


        //
    }
}
