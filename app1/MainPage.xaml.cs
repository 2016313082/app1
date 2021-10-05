

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace app1
{
    public partial class MainPage : ContentPage
    {
        int _count;
        string _message;
        Button button1;

        public MainPage()
        {
            InitializeComponent();
            _count = 0;
        }

        private void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (button1 == null)
                button1 = ((Button)sender);
            _count++;
            _message = "Has hecho tab {0} veces";
            button1.Text = string.Format(_message, _count);
        }

        private void Reset_Clicked(object sender, System.EventArgs e)
        {
            _message = "Haz tab en mi!";
            if (button1 != null)
                button1.Text = _message;
            _count = 0;
        }
    }
}
