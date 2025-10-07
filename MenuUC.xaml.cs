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

namespace POSApp
{
    /// <summary>
    /// Interaction logic for MenuUC.xaml
    /// </summary>
    public partial class MenuUC : UserControl
    {
        private MainWindow _mainWindow;
        public MenuUC(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            PopulateMenuItems();
        }
        private void PopulateMenuItems()
        {
            // Example menu items
            var menuItems = new List<string>
            {
                "Espresso",
                "Cappuccino",
                "Latte",
                "Mocha",
                "Tea",
                "Hot Chocolate",
                "Sandwich",
                "Salad",
                "Cake",
                "Cookie",
                "lorem",
                "lorem2",
                "lorem3",
                "lorem4",
                "lorem5",
                "lorem6",
                "lorem7",
                "lorem8",
                "lorem9",
                "lorem10",

                "lorem",
                "lorem",

            };
            foreach (var item in menuItems)
            {
                var button = new Button
                {

                    Content = item,
                    Margin = new Thickness(5),
                    Height = 40,
                    Width = 100
                };
                button.Click += MenuItem_Click;
                MenuItemsGrid.Children.Add(button);
            }
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                string itemName = button.Content.ToString();
                MessageBox.Show($"You selected: {itemName}", "Menu Item Selected", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            // Handle logout logic here
            //Clear Cart()

            
            _mainWindow.showLogin();
            //.Current.Shutdown();
            return;

        }
    }
}

