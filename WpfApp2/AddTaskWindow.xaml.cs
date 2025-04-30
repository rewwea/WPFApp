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

namespace WpfApp2
{
    public partial class AddTaskWindow : Window
    {
        public Task NewTask { get; set; }
        public AddTaskWindow()
        {
            InitializeComponent();
        }

        // Save button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewTask = new Task
            {
                Id = new Random().Next(),
                Title = TitleTextBox.Text,
                Description = DescriptionTextBox.Text,
                Priority = PriorityComboBox.Text
            };
            DialogResult = true;
        }

        // Cancel button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
