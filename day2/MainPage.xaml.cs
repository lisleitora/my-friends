using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace day2
{
    public partial class MainPage : ContentPage
    {
        string amiga;
        public MainPage()
        {
            InitializeComponent();
        }

        void _saveButton_Clicked(System.Object sender, System.EventArgs e)
        {
            amiga = amiga+"\n"+_nameEntry.Text;
            _textLabel.Text = amiga;

        }
    }
}
//    public partial class MainPage : ContentPage
//    {
//        string amiga;
//        public MainPage()
//        {
//            InitializeComponent();
//        }

//        void _saveButton_Clicked(System.Object sender, System.EventArgs e)
//        {
//            amiga = amiga + "\n " + _nameEntry.Text;
//            _textLabel.Text = amiga;

//        }
//    }
//}

