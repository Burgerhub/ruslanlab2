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
using System.Windows.Shapes;

namespace ruslanprackt2var10
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int A = int.Parse(vod1.Text);
            int B = int.Parse(vod2.Text);
            int C = int.Parse(vod3.Text);



            int numSquares = (A / C) * (B / C);
            int freeArea = A * B - numSquares * C * C;

            otv.Text = $"Количество квадратов:{ numSquares} \n Площадь незанятой части:{freeArea} ";
        }
    }
}
