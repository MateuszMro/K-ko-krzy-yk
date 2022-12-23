using Microsoft.Win32;
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

namespace Kółko_i_krzyżyk___projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        bool gracz1 = true;
        int ruch = 0;
        private void Restartuj_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Czy chcesz zrestartować grę?", "UWAGA!", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Restart();
                WynikO.Text = "0";
                WynikX.Text = "0";
                RuchGracza.Text = "O";
                gracz1 = true;
            }
            else
                return;
            
        }

        private void Restart()
        {
            ruch = 0;
            Button[] all = new Button[9];
            all[0] = Btn1;
            all[1] = Btn2;
            all[2] = Btn3;
            all[3] = Btn4;
            all[4] = Btn5;
            all[5] = Btn6;
            all[6] = Btn7;
            all[7] = Btn8;
            all[8] = Btn9;
            foreach (Button b in all)
            {
                b.IsEnabled = true;
                b.Content = "";
            }
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            ruch++;
            ((Button)sender).Content = gracz1 ? "O" : "X";
            ((Button)sender).IsEnabled = false;
            if ( ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            RuchGracza.Text = gracz1 ? "O" : "X";
        }

        private void Sprawdz()
        {
            if(Btn1.Content != "" && Btn1.Content == Btn2.Content && Btn2.Content == Btn3.Content)
            {
                Wygrana();
            }
            else if( Btn4.Content != "" && Btn4.Content==Btn5.Content && Btn5.Content == Btn6.Content)
            {
                Wygrana();
            }
            else if (Btn7.Content !="" && Btn7.Content == Btn8.Content && Btn8.Content == Btn9.Content)
            {
                Wygrana();
            }
            else if(Btn1.Content != "" && Btn1.Content == Btn4.Content && Btn4.Content == Btn7.Content)
            {
                Wygrana();
            }
            else if (Btn2.Content != "" && Btn2.Content == Btn5.Content && Btn5.Content == Btn8.Content)
            {
                Wygrana();
            }
            else if (Btn3.Content!="" && Btn3.Content == Btn6.Content && Btn6.Content == Btn9.Content)
            {
                Wygrana();
            }
            else if (Btn1.Content != "" && Btn1.Content == Btn5.Content && Btn5.Content == Btn9.Content)
            {
                Wygrana();
            }
            else if (Btn3.Content != "" && Btn3.Content == Btn5.Content && Btn5.Content == Btn7.Content)
            {
                Wygrana();
            }
            else if (ruch == 9)
            {
                MessageBox.Show("Remis", "Koniec gry", MessageBoxButton.OK, MessageBoxImage.Warning);
                Restart();
            }

        }

        private void Wygrana()
        {
            MessageBox.Show("Wygrywa gracz: " + (gracz1 ? "O" : "X"), "Wygrana!", MessageBoxButton.OK, MessageBoxImage.Warning);
            if (gracz1)
            {
                WynikO.Text = ((int.Parse(WynikO.Text)) + 1).ToString();
            }
            else
            {
                WynikX.Text = ((int.Parse(WynikX.Text)) + 1).ToString();
            }
            Restart();
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            ruch++;
            ((Button)sender).Content = gracz1 ? "O" : "X";
            ((Button)sender).IsEnabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            RuchGracza.Text = gracz1 ? "O" : "X";
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            ruch++;
            ((Button)sender).Content = gracz1 ? "O" : "X";
            ((Button)sender).IsEnabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            RuchGracza.Text = gracz1 ? "O" : "X";
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            ruch++;
            ((Button)sender).Content = gracz1 ? "O" : "X";
            ((Button)sender).IsEnabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            RuchGracza.Text = gracz1 ? "O" : "X";
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            ruch++;
            ((Button)sender).Content = gracz1 ? "O" : "X";
            ((Button)sender).IsEnabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            RuchGracza.Text = gracz1 ? "O" : "X";
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            ruch++;
            ((Button)sender).Content = gracz1 ? "O" : "X";
            ((Button)sender).IsEnabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            RuchGracza.Text = gracz1 ? "O" : "X";
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            ruch++;
            ((Button)sender).Content = gracz1 ? "O" : "X";
            ((Button)sender).IsEnabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            RuchGracza.Text = gracz1 ? "O" : "X";
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            ruch++;
            ((Button)sender).Content = gracz1 ? "O" : "X";
            ((Button)sender).IsEnabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            RuchGracza.Text = gracz1 ? "O" : "X";
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            ruch++;
            ((Button)sender).Content = gracz1 ? "O" : "X";
            ((Button)sender).IsEnabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            RuchGracza.Text = gracz1 ? "O" : "X";
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text file (*.txt) | (* txt)";
            saveFileDialog.InitialDirectory = @"C:\Users\1\Desktop\Studia materiały\Programowanie I C#";
            saveFileDialog.Title = "Zapisz do pliku tekstowego";

            if(saveFileDialog.ShowDialog() == true)
            {
                using (var fileStream = new System.IO.FileStream(saveFileDialog.FileName, System.IO.FileMode.OpenOrCreate))
                {
                    using(var streamWriter = new System.IO.StreamWriter(fileStream))
                    {
                        streamWriter.WriteLine("Ruch gracza: " + RuchGracza.Text);
                        streamWriter.WriteLine("Wynik gracza O: " + WynikO.Text);
                        streamWriter.WriteLine("Wynik gracza X: " + WynikX.Text);
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.White;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Blue;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Green;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Yellow;
        }
    }
}
