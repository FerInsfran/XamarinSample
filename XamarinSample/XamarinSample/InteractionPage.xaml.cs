using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InteractionPage : ContentPage
    {
        public InteractionPage()
        {
            InitializeComponent();
        }

        private void interactionButton_Clicked(object sender, EventArgs e)
        {
            decimal result = Convert.ToDecimal(firstValueEntry.Text) + Convert.ToDecimal(secondtValueEntry.Text);

            resultLabel.Text = result.ToString("#.##");

            
        }
    }
}