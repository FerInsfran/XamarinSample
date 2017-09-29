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
    public partial class ToDoPage : ContentPage
    {

        public List<string> ToDoItems { get; set; }

        public ToDoPage()
        {
            InitializeComponent();

            this.ToDoItems = new List<string>();
        }

        private void addItemButton_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(newToDoItemEntry.Text))
            {
                DisplayAlert("Error", "Please enter a value", "Ok");
            }
            else
            {
                this.ToDoItems.Add(newToDoItemEntry.Text);

                toDoList.ItemsSource = this.ToDoItems;

                newToDoItemEntry.Text = "";
            }


        }
    }
}