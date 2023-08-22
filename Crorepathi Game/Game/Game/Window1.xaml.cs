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
using System.Windows.Shapes;

namespace Game
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
 
        public Window1()
        {
            InitializeComponent();
        }


        private void Common_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Content = btn.Tag;           
            btn.IsEnabled = false;
            int total = Convert.ToInt32(btn.Tag);
            if (txtplayer1.Tag.ToString() == "0")
            {
                int prevamount = total +  Convert.ToInt32(txtplayer1.Text);
                txtplayer1.Text = prevamount.ToString();
                txtplayer1.Tag = "1";
                txtplayer2.Tag = "0";
            }
            else if(txtplayer2.Tag.ToString() == "0") {
                int prevamount = total + Convert.ToInt32(txtplayer2.Text);
                txtplayer2.Text = prevamount.ToString();
                txtplayer1.Tag = "0";
                txtplayer2.Tag = "1";
            }
        }
    }
}

