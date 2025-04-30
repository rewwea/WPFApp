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
    public partial class EditTaskWindow : Window
    {
        public Task UpdatedTask { get; set; }

        public EditTaskWindow(Task task)
        {
            InitializeComponent();
            UpdTitleTextBox.Text = task.Title;
            UpdDescriptionTextBox.Text = task.Description;
            UpdPriorityComboBox.Text = task.Priority;
            UpdatedTask = task;
        }

        // Save button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UpdatedTask.Title = UpdTitleTextBox.Text;
            UpdatedTask.Description = UpdDescriptionTextBox.Text;
            UpdatedTask.Priority = (UpdPriorityComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            DialogResult = true;
        }

        // Cancel button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
