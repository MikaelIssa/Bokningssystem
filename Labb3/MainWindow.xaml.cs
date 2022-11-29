using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Labb3
{

    public partial class Reservation : Window
    {
        List<Booking> bookings = new List<Booking>()
        {new Booking("Micke", "10:00", "2022/4/11", " 2"),
        new Booking("Jack", "12:00", "2022/4/11", " 4"),
        new Booking("king", "09:00", "2022/4/11", " 5")};


        string[] TimeToPick = { "08:00", "09:00", "11:00", "12:00", "14:00", "15:00", "17:00", "18:00", "20:00", "21:00", "22:00" };
        string[] TableBooked = { "1", "2", "3", "4", "5" };
        


        public Reservation()
        {
            InitializeComponent();
            foreach (Booking booking in bookings)
            {

                myList.Items.Add(booking);

            }
            
            timeInput.ItemsSource = TimeToPick;
            tableInput.ItemsSource = TableBooked;

        }


        public void Bookings()
        {
            DateTime? valdDatum = dateInput.SelectedDate;
            Booking booking = new Booking(nameInput.Text, timeInput.Text, dateInput.Text, tableInput.Text);

            var bokadVidSammaTid =
                     (from valdBokning in bookings
                      where valdBokning.Time == timeInput.SelectedItem.ToString()
                      && valdBokning.Date == valdDatum.Value.ToString("yyyy/MM/dd")
                      && valdBokning.TableNumber == tableInput.SelectedItem.ToString()
                      select valdBokning).Any();

            foreach (var checkbooking in bookings)
            {

                if (bokadVidSammaTid)
                {
                    MessageBox.Show("Its already booked!");
                    return;
                }
                else
                {
                    bookings.Add(booking);
                    myList.Items.Add(booking);

                    MessageBox.Show("Its booked!");
                    break;
                }

            }
        }
        private void Clear_Add()
        {
            myList.Items.Clear();
            foreach (var bokning in bookings)
            {
                myList.Items.Add(bokning.Name + ", " + bokning.Date.ToString() + ", " + bokning.Time.ToString() + ", " + bokning.TableNumber.ToString());
            }
        }

        private void Button_DeleteBooking(object sender, RoutedEventArgs e)
        {
            if (myList.SelectedItem != null)
            {
                bookings.RemoveAt(myList.SelectedIndex);
                Clear_Add();
            }



            //myList.Items.RemoveAt(myList.Items.IndexOf(myList.SelectedItem));
            //bookings.RemoveAt(myList.Items.IndexOf(myList.SelectedItem));
        }


        private void Button_AddBooking(object sender, RoutedEventArgs e)
        {
            Bookings();

        }

        private void Button_Bookningar(object sender, RoutedEventArgs e)
        {
            try
            {
                myList.Items.Clear();

                foreach (Booking item in bookings)
                {
                    myList.Items.Add(item.ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Det blev ett fel." + ex.Message);
            }

            

        }

    }
   
}
