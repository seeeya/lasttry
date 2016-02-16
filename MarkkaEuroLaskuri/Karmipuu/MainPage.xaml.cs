using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Karmipuu
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double lkorkeus = double.Parse(lKorkeus.Text);
            double lleveys = double.Parse(lLeveys.Text);
            double kleveys = double.Parse(kKorkeus.Text); // väärän niminen laatikko formissa joten ei tarvii välittää
            double ikkunapintaa = (lkorkeus) * (lleveys)/10; //cm^2
            double lasinpintaa = (lkorkeus - kleveys - kleveys) *(lleveys-kleveys-kleveys)/10; // ^cm2
            double karmipiirii = (lkorkeus  + lleveys)*2/10; // cm
            string ikkunap = ikkunapintaa.ToString("0");
            string lasip = lasinpintaa.ToString("0");
            string karmipii = karmipiirii.ToString("0");
            ikkunapinta.Text = ikkunap + " cm^2";
            lasipinta.Text = lasip + " cm^2";
            karmipiiri.Text = karmipii +" cm";
        }
    }
}
