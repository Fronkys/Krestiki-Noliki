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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Security;
using System.Reflection.Emit;
using System.Runtime.Remoting.Channels;

namespace Based
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int player;
        public MainWindow()
        {
            InitializeComponent();
            player = 1;
            Label1.Content = "Крестики нолики";
            
        }

        

        private void Button(object sender, RoutedEventArgs e)
        {
            button1.IsEnabled = true;
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            button5.IsEnabled = true;
            button6.IsEnabled = true;
            button7.IsEnabled = true;
            button8.IsEnabled = true;
            button9.IsEnabled = true;
            button1.Content = "";
            button2.Content = "";
            button3.Content = "";
            button4.Content = "";
            button5.Content = "";
            button6.Content = "";
            button7.Content = "";
            button8.Content = "";
            button9.Content = "";
        }

        private void button_game(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Content").SetValue(sender, "x");
                    player = 0;
                    break;
                case 0:
                    sender.GetType().GetProperty("Content").SetValue(sender, "o");
                    player = 1;
                    break;
                  
            }
            sender.GetType().GetProperty("IsEnabled").SetValue (sender, false);
            MethodCheck();
            

        }
        

        private void Robot()
        {
            Random random = new Random();
            int chislo = random.Next(1, 9);

        }
        
        private void MethodCheck()
        {
            if(button1.Content == button2.Content && button2.Content == button3.Content)
            {
                if (button1.Content != "")
                {
                    MessageBox.Show("Победа");
                }
                
            }
            if (button4.Content == button5.Content && button5.Content == button6.Content)
            {
                
                    if (button4.Content != "")
                    {
                        MessageBox.Show("Победа");
                    }


            }
            if (button7.Content == button8.Content && button8.Content == button9.Content)
            {
                
                    if (button7.Content != "")
                    {
                        MessageBox.Show("Победа");
                    }


            }
            if (button1.Content == button4.Content && button4.Content == button7.Content)
            {
                
                    if (button1.Content != "")
                    {
                        MessageBox.Show("Победа");
                    }
            }
            if (button2.Content == button5.Content && button5.Content == button8.Content)
            {
                
                    if (button2.Content != "")
                    {
                        MessageBox.Show("Победа");
                    }



            }
            if (button3.Content == button6.Content && button6.Content == button9.Content)
            {
                
                    if (button3.Content != "")
                    {
                        MessageBox.Show("Победа");
                    }

            }
            if (button1.Content == button5.Content && button5.Content == button9.Content)
            {
                
                    if (button1.Content != "")
                    {
                        MessageBox.Show("Победа");
                    }



            }
            if (button7.Content == button5.Content && button5.Content == button3.Content)
            {
                
                    if (button7.Content != "")
                    {
                        MessageBox.Show("Победа");
                    }

            }
       
        }
        
        


    }
}
