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

namespace t_t_e
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int XorY;
        private static List<int> poleList = new List<int>();
        private int Resmove;
        public MainWindow()
        {
            InitializeComponent();
            offpole();
        }
        private void Obut_Click(object sender, RoutedEventArgs e)
        {
            XorY = 0;
            Resmove = XorY;
            Obut.IsEnabled = false;
            XBut.IsEnabled = false;
            vklpole();
        }
        private void XBut_Click(object sender, RoutedEventArgs e)
        {
            XorY = 1;
            Resmove = XorY;
            XBut.IsEnabled = false;
            Obut.IsEnabled = false;
            vklpole();
        }
        private void but1_Click(object sender, RoutedEventArgs e)
        {
            Ngbut.IsEnabled = true;
            if (XorY == 0)
            {
                sender.GetType().GetProperty("Content").SetValue(sender, "O");
                XorY = 1;
                poleList.Add(1);
                if (poleList.Count != 9)
                {
                    AI();
                    XorY = 0;
                }
            }
            else if (XorY == 1)
            {
                sender.GetType().GetProperty("Content").SetValue(sender, "X");
                XorY = 0;
                poleList.Add(1);
                if (poleList.Count != 9)
                {
                    AI();
                    XorY = 1;
                }
            }
            sender.GetType().GetProperty("IsEnabled").SetValue(sender, false);
            pobeda();
        }

        private void vklpole()
        {
            knopka1.IsEnabled = true;
            knopka2.IsEnabled = true;
            knopka3.IsEnabled = true;
            knopka4.IsEnabled = true;
            knopka5.IsEnabled = true;
            knopka6.IsEnabled = true;
            knopka7.IsEnabled = true;
            knopka8.IsEnabled = true;
            knopka9.IsEnabled = true;
        }
        private void pobeda()
        {
            if (poleList.Count == 9)
            {
                WinnerTB.Text = "победитель: Расход пацаны";
                if(XorY == 1)
                {
                    XorY = 0;
                }
                else
                {
                    XorY = 1;
                }
            }
            else
            {
                if (knopka1.Content == knopka2.Content && knopka2.Content == knopka3.Content)
                {
                    if (knopka1.Content.ToString() != "")
                    {
                        if (knopka1.Content.ToString() == "O")
                        {
                            WinnerTB.Text = "победитель: O";
                            offpole();
                            Ngbut.IsEnabled = true;
                        }
                        else
                        {
                            WinnerTB.Text = "победитель: X";
                            offpole();
                            Ngbut.IsEnabled = true;
                        }
                    }
                }
                if (knopka4.Content == knopka5.Content && knopka5.Content == knopka6.Content)
                {
                    if (knopka6.Content.ToString() != "")
                    {
                        if (knopka6.Content.ToString() == "O")
                        {
                            WinnerTB.Text = "победитель: O";
                            offpole();
                            Ngbut.IsEnabled = true;
                        }
                        else
                        {
                            WinnerTB.Text = "победитель: X";
                            offpole();
                            Ngbut.IsEnabled = true;
                        }
                    }
                }
                if (knopka7.Content == knopka8.Content && knopka8.Content == knopka9.Content)
                {
                    if (knopka7.Content.ToString() != "")
                    {
                        if (knopka7.Content.ToString() == "O")
                        {
                            WinnerTB.Text = "победитель: O";
                            offpole();
                            Ngbut.IsEnabled = true;
                        }
                        else
                        {
                            WinnerTB.Text = "победитель: X";
                            offpole();
                            Ngbut.IsEnabled = true;
                        }
                    }
                }
                if (knopka1.Content == knopka4.Content && knopka4.Content == knopka7.Content)
                {
                    if (knopka4.Content.ToString() != "")
                    {
                        if (knopka4.Content.ToString() == "O")
                        {
                            WinnerTB.Text = "победитель: O";
                            offpole();
                            Ngbut.IsEnabled = true;
                        }
                        else
                        {
                            WinnerTB.Text = "победитель: X";
                            offpole();
                            Ngbut.IsEnabled = true;
                        }
                    }
                }
                if (knopka2.Content == knopka5.Content && knopka5.Content == knopka8.Content)
                {
                    if (knopka8.Content.ToString() != "")
                    {
                        if (knopka8.Content.ToString() == "O")
                        {
                            WinnerTB.Text = "победитель: O";
                            offpole();
                            Ngbut.IsEnabled = true;
                        }
                        else
                        {
                            WinnerTB.Text = "победитель: X";
                            offpole();
                            Ngbut.IsEnabled = true;
                        }
                    }
                }
                if (knopka3.Content == knopka6.Content && knopka6.Content == knopka9.Content)
                {
                    if (knopka3.Content.ToString() != "")
                    {
                        if (knopka3.Content.ToString() == "O")
                        {
                            WinnerTB.Text = "победитель: O";
                            offpole();
                            Ngbut.IsEnabled = true;
                        }
                        else
                        {
                            WinnerTB.Text = "победитель: X";
                            offpole();
                            Ngbut.IsEnabled = true;
                        }
                    }
                }
                if (knopka1.Content == knopka5.Content && knopka5.Content == knopka9.Content)
                {
                    if (knopka9.Content.ToString() != "")
                    {
                        if (knopka9.Content.ToString() == "O")
                        {
                            WinnerTB.Text = "победитель: O";
                            offpole();
                            Ngbut.IsEnabled = true;
                        }
                        else
                        {
                            WinnerTB.Text = "победитель: X";
                            offpole();
                            Ngbut.IsEnabled = true;
                        }
                    }
                }
                if (knopka3.Content == knopka5.Content && knopka5.Content == knopka7.Content)
                {
                    if (knopka5.Content.ToString() != "")
                    {
                        if (knopka5.Content.ToString() == "O")
                        {
                            WinnerTB.Text = "победитель: O";
                            offpole();
                            Ngbut.IsEnabled = true;
                        }
                        else
                        {
                            WinnerTB.Text = "победитель: X";
                            offpole();
                            Ngbut.IsEnabled = true;
                        }
                    }
                }
            }
        }

        private void offpole()
        {
            knopka1.IsEnabled = false;
            knopka2.IsEnabled = false;
            knopka3.IsEnabled = false;
            knopka4.IsEnabled = false;
            knopka5.IsEnabled = false;
            knopka6.IsEnabled = false;
            knopka7.IsEnabled = false;
            knopka8.IsEnabled = false;
            knopka9.IsEnabled = false;
            Ngbut.IsEnabled = false;
        }

        private void Ngbut_Click(object sender, RoutedEventArgs e)
        {
            if (XorY == 1)
            {
                XorY = 0;
            }
            else
            {
                XorY = 1;
            }
            WinnerTB.Text = "";
            vklpole();
            ocistpole();
            poleList.Clear();
        }
        private void AI()
        {
            Random buttt = new Random();
            bool close = true;
            while (close)
            {
                int shag = buttt.Next(1, 9);
                if(shag == 1)
                {
                    if (knopka1.Content.ToString() == "")
                    {
                        if (XorY == 0)
                        {
                            knopka1.Content = "O";
                        }
                        else
                        {
                            knopka1.Content = "X";
                        }
                        poleList.Add(1);
                        knopka1.IsEnabled = false;
                        close = false;
                    }
                }
                if(shag == 2)
                {
                    if (knopka2.Content.ToString() == "")
                    {
                        if (XorY == 0)
                        {
                            knopka2.Content = "O";
                        }
                        else
                        {
                            knopka2.Content = "X";
                        }
                        poleList.Add(1);
                        knopka2.IsEnabled = false;
                        close = false;
                    }
                }
                if (shag == 3)
                {
                    if (knopka3.Content.ToString() == "")
                    {
                        if (XorY == 0)
                        {
                            knopka3.Content = "O";
                        }
                        else
                        {
                            knopka3.Content = "X";
                        }
                        poleList.Add(1);
                        knopka3.IsEnabled = false;
                        close = false;
                    }
                }
                if (shag == 4)
                {
                    if (knopka4.Content.ToString() == "")
                    {
                        if (XorY == 0)
                        {
                            knopka4.Content = "O";
                        }
                        else
                        {
                            knopka4.Content = "X";
                        }
                        poleList.Add(1);
                        knopka4.IsEnabled = false;
                        close = false;
                    }
                }
                if (shag == 5)
                {
                    if (knopka5.Content.ToString() == "")
                    {
                        if (XorY == 0)
                        {
                            knopka5.Content = "O";
                        }
                        else
                        {
                            knopka5.Content = "X";
                            poleList.Add(1);
                        }
                        poleList.Add(1);
                        knopka5.IsEnabled = false;
                        close = false;
                    }
                }
                if (shag == 6)
                {
                    if (knopka6.Content.ToString() == "")
                    {
                        if (XorY == 0)
                        {
                            knopka6.Content = "O";
                        }
                        else
                        {
                            knopka6.Content = "X";
                        }
                        poleList.Add(1);
                        knopka6.IsEnabled = false;
                        close = false;
                    }
                }
                if (shag == 7)
                {
                    if (knopka7.Content.ToString() == "")
                    {
                        if (XorY == 0)
                        {
                            knopka7.Content = "O";
                        }
                        else
                        {
                            knopka7.Content = "X";
                        }
                        poleList.Add(1);
                        knopka7.IsEnabled = false;
                        close = false;
                    }
                }
                if (shag == 8)
                {
                    if (knopka8.Content.ToString() == "")
                    {
                        if (XorY == 0)
                        {
                            knopka8.Content = "O";
                        }
                        else
                        {
                            knopka8.Content = "X";
                        }
                        poleList.Add(1);
                        knopka8.IsEnabled = false;
                        close = false;
                    }
                }
                if (shag == 9)
                {
                    if (knopka9.Content.ToString() == "")
                    {
                        if (XorY == 0)
                        {
                            knopka9.Content = "O";
                        }
                        else
                        {
                            knopka9.Content = "X";
                        }
                        poleList.Add(1);
                        knopka9.IsEnabled = false;
                        close = false;
                    }
                }
            }
        }

        private void ocistpole()
        {
            knopka1.Content = "";
            knopka2.Content = "";
            knopka3.Content = "";
            knopka4.Content = "";
            knopka5.Content = "";
            knopka6.Content = "";
            knopka7.Content = "";
            knopka8.Content = "";
            knopka9.Content = "";
        }

    }
}
