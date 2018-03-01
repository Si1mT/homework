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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<TodoItem> items = new List<TodoItem>();
            items.Add(new TodoItem() { Title = "Complete this WPF tutorial", Completion = 45 });
            items.Add(new TodoItem() { Title = "Learn C#", Completion = 80 });
            items.Add(new TodoItem() { Title = "Go to shop", Completion = 100 });
            items.Add(new TodoItem() { Title = "Buy stuff", Completion = 10 });

            TodoListBox.ItemsSource = items;

            List<Human> humans = new List<Human>();
            humans.Add(new Human() { Name = "Jake", LastName = "Paul", Age = 10 });
            humans.Add(new Human() { Name = "Alfred", LastName = "Hitch", Age = 40 });

            Users.ItemsSource = humans;
        }
    }
    public class TodoItem
    {
        public string Title { get; set; }
        public int Completion { get; set; }
    }
    public class Human
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
