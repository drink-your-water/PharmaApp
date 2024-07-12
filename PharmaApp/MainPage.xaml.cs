using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Example: Add some dummy data to the list initially
            for (int i = 1; i <= 20; i++)
            {
                var label = new Label
                {
                    Text = $"Item {i}",
                    FontSize = 24,
                    Margin = new Thickness(10)
                };
                listContainer.Children.Add(label);
            }
        }

        // Handle camera button click
        private void OnCameraButtonClicked(object sender, EventArgs e)
        {
            // Implement camera functionality here
            DisplayAlert("Camera", "Camera button clicked!", "OK");
        }
    }
}
