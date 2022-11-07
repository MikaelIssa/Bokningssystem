﻿using System;
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

namespace Labb3
{
    
    public partial class Reservation : Window
    {
        List<Booking> bookings = new List<Booking>()
        {new Booking("Micke", "10:00", "4/11", "table 2"),
        new Booking("Jack", "12:00", "4/11", "table 4"),
        new Booking("king", "09:00", "4/11", "table 5")};
       

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
        // private void RefreshList()
        // {
        //     myList.ItemsSource = null;
        //     myList.ItemsSource = bookings;
        //     if (bookings.Count != 0)
        //     {
        //         foreach (Booking booking in bookings)
        //         {

        //             myList.Items.Add(booking);

        //         }
        //     }
        //     else
        //     {
        //         myList.Items.Add("No items in list");
        //     }


        // }


        

        private void Button_DeleteBooking(object sender, RoutedEventArgs e)
        {
          myList.Items.RemoveAt(myList.Items.IndexOf(myList.SelectedItem));
        //   bookings.RemoveAt(bookings.IndexOf(bookings.SelectedItem));
            
        }

        

        private void Button_AddBooking(object sender, RoutedEventArgs e)
        {

           
            Booking booking = new Booking(nameInput.Text, timeInput.Text, dateInput.Text, tableInput.Text);
            bookings.Add(booking);
            myList.Items.Add(booking);
            // RefreshList();


        }

        private void Button_Bookningar(object sender, RoutedEventArgs e)
        {
            foreach (Booking booking in bookings)
                {

                    myList.Items.Add(booking);

                }
            // RefreshList()
        }
    }

}