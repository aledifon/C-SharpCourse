using System.Collections;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDemo.Data;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ////Person person = new Person(30,"Jannick");        
        //Person person = new Person
        //{
        //    Name = "Jannick",
        //    Age = 30
        //};

        public List<Person> People = new List<Person>
        {
            new Person{Name="Jannick",Age= 30},
            new Person{Name="Marc",Age= 20},
            new Person{Name="Maria",Age= 40},
            new Person{Name="Scott",Age= 35},
            new Person{Name="Lucas",Age= 27},
        };

        public MainWindow()
        {
            InitializeComponent();

            ListBoxPeople.ItemsSource = People;            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxPeople.SelectedItems;
            foreach (var item in selectedItems)
            {
                var person = (Person)item;
                MessageBox.Show("Name: " + person.Name + "Age: " + person.Age.ToString());                
            }
        }
    }
}