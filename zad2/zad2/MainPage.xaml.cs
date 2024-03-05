using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace zad2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int like = 0;
        public void polubienie(object sender, EventArgs e)
        {
            like++;
            result.Text = like.ToString() + " polubień";
        }
        public void depolubienie(object sender, EventArgs e)
        {
            if(like > 0)
                    like--;
            result.Text = like.ToString() + " polubień";
        }
    }
}
