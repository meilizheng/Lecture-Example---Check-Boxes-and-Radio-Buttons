using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Xps.Serialization;
//Meili Zheng;
//Lecture Example - Check Boxed and Radio Buttons;
//02/17/2023;

namespace Lecture_Example___Check_Boxes_and_Radio_Buttons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Preload();
        }
        void Preload()
        {
            rbSmall.IsChecked = true;
            rbDrinkSmall.IsChecked = true;
        }
       
        private void btnOrderPizza_Click(object sender, RoutedEventArgs e)
        {
            double amount = 0;
            runReciept.Text = txtCustomerName.Text + "\n";
            bool hasPeperoni = ckPepperoni.IsChecked.Value;
            bool hasCheese= ckCheese.IsChecked.Value;
            bool hasMushrooms = ckMushrooms.IsChecked.Value;
            bool hasPineapple = ckPineapple.IsChecked.Value;
            bool sizeSmall = rbSmall.IsChecked.Value;
            bool sizeMedium = rbMedium.IsChecked.Value;
            bool sizeLarge = rbLarge.IsChecked.Value;
            bool sizeExtraLarge = rbExtraLarge.IsChecked.Value;
            bool drinkSmall = rbDrinkSmall.IsChecked.Value;
            bool drinkMedium = rbDrinkMedium.IsChecked.Value;
            bool drinkLarge = rbDrinkLarge.IsChecked.Value;
            bool drinlExtraLarge = rbDrinkExtraLarge.IsChecked.Value;


            runReciept.Text += "\nTopping of Pizza:\n";

            if (hasPeperoni)
            {
                double toppingprice = 4;
                runReciept.Text += $"Peperoni - {toppingprice.ToString("c")} \n";
                amount += toppingprice;
            }
            if (hasCheese)
            {
                double toppingprice = 5;
                runReciept.Text += $"Cheese - {toppingprice.ToString("c")} \n";
                amount += toppingprice;
            }
            if (hasMushrooms)
            {
                double toppingprice = 2;
                runReciept.Text += $"Mushrooms - {toppingprice.ToString("c")} \n";
                amount += toppingprice;
            }
            if (hasPineapple)
            {
                double toppingprice = 8;
                runReciept.Text += $"Pineapple - {toppingprice.ToString("c")} \n";
                amount += toppingprice;
            }

            double price = 0;
            runReciept.Text += "Pizza Size: ";            
            if (sizeSmall)
            {
                runReciept.Text += "Small";
                price = 13;
            }
            else if (sizeMedium)
            {
                runReciept.Text += "Medium";
                price = 15;
            }
            else if (sizeLarge)
            {
                runReciept.Text += "Large";
                price = 18;
            }
            else if (sizeExtraLarge)
            {
                runReciept.Text += "Extra Large";
                price = 20;
            }

            runReciept.Text += " - " + "$" + price.ToString() + "\n";
            amount += price;

            runReciept.Text += "Drink Size: ";            
            if (drinkSmall)
            {
                double drinkprice = 2;
                runReciept.Text += $"Small drink - {drinkprice.ToString("c")} \n";
                amount += drinkprice;
            }
            else if (drinkMedium)
            {
                double drinkprice = 3.75;
                runReciept.Text += $"Medium drink - {drinkprice.ToString("c")} \n";
                amount += drinkprice;
            }
            else if (drinkLarge)
            {
                double drinkprice = 4.75;
                runReciept.Text += $"Large drink - {drinkprice.ToString("c")} \n";
                amount += drinkprice;
            }
            else if (drinlExtraLarge)
            {
                double drinkprice = 7;
                FormatItem("XL Drink", drinkprice);                
                amount += drinkprice;
            }
            double taxAmount = .1;
            double calculatedTax = amount * taxAmount;
            double totalAmount = amount + calculatedTax;
            runReciept.Text += $"\n" + $"Subtotal:{amount.ToString("c")}\n" + 
                $"Tax Amount： {calculatedTax.ToString("c")}\n" + 
                $"Total price: $ {totalAmount.ToString("c")}\n";
        }

        public string FormatItem(string item, double amount)
        {
            return $"{item} - {amount.ToString("c")}\n";
        }
    }
}
