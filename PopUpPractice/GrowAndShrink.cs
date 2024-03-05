﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PopUpPractice
{
    public class GrowAndShrink : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new GrowAndShrink());
        }

        public GrowAndShrink()
        {
            Title = "Grow & SHrink";
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Width = 192;
            Height = 192;
        }

        protected override void OnKeyDown(KeyEventArgs args)
        {
            base.OnKeyDown(args);
            if (args.Key == Key.Up)
            {   
                Left -= 0.05 * Width;
                Top -= 0.05 * Height;
                Width *= 1.1;
                Height *= 1.1;
            }
            else if (args.Key == Key.Down)
            {
                Left += 0.05 * (Width /= 1.1);
                Top += 0.05 * (Height /= 1.1);
            }
        }
    }
}
