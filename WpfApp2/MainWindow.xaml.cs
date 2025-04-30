using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp2
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
    }
    public partial class MainWindow : Window
    {
        public ObservableCollection<Task> Tasks { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<Task>();
            TaskListBox.ItemsSource = Tasks;
        }

        // Add button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddTaskWindow addTaskWindow = new AddTaskWindow();
            if (addTaskWindow.ShowDialog() == true)
            {
                Tasks.Add(addTaskWindow.NewTask);
            }
        }

        // Edit button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (TaskListBox.SelectedItem is Task selectedTask)
            {
                EditTaskWindow editTaskWindow = new EditTaskWindow(selectedTask);
                if (editTaskWindow.ShowDialog() == true)
                {
                    int i = Tasks.IndexOf(selectedTask);
                    Tasks[i] = editTaskWindow.UpdatedTask;
                }
            }
        }

        // Delete button
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (TaskListBox.SelectedItem is Task selectedTask)
            {
                Tasks.Remove(selectedTask);
            }
        }
    }
}
