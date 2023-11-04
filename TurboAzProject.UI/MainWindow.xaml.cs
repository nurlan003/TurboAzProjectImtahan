using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TurboAzProject.Data.Context;
using TurboAzProject.Model.Models;

namespace TurboAzProject.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        public ObservableCollection<Car> cars = new();
            TurboAzContext Context = new TurboAzProject.Data.Context.TurboAzContext();
        public MainWindow()
        {
            InitializeComponent();
            foreach (var car in Context.Cars.ToList())
            {
                cars.Add(car);
            }

            CarListView.ItemsSource = cars;
            DataContext = this;

            List<string> bzmarka = new List<string>();
            foreach (var marka in Context.Markas.ToList())
            {
                bzmarka.Add(marka.MarkaName);
            }
            MarkaCBX.ItemsSource = bzmarka;

            List<string> bzcity = new List<string>();
            foreach (var color in Context.Cities.ToList())
            {
                bzcity.Add(color.Name);
            }
            CityCBX.ItemsSource = bzcity;

            List<string> bzacc = new List<string>();
            foreach (var acc in Context.AcceleratingBoxes.ToList())
            {
                bzacc.Add(acc.AcceleratingBox1);
            }
            AccBoxCBX.ItemsSource = bzacc;


            List<string> bzcolor = new List<string>();
            foreach (var color in Context.Colors.ToList())
            {
                bzcolor.Add(color.Color1);
            }
            ColorTBX.ItemsSource = bzcolor;

            List<string> bzfuel = new List<string>();
            foreach (var fuel in Context.FuelTypes.ToList())
            {
                bzfuel.Add(fuel.FuelType1);
            }
            fUELTYPETBX.ItemsSource = bzfuel;



            //Dapper
           //string connectionString = "Data Source=NURLANJAVADZADA;Initial Catalog=TurboAz;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
           //using IDbConnection dbConnection = new SqlConnection(connectionString);


           // string querymarka = "SELECT * FROM Marka";
           // var datamarka = dbConnection.Query<Marka>(querymarka);
           // List<string> dpmarka = new List<string>();
           // foreach (var item in datamarka)
           // {
           //     dpmarka.Add(item.MarkaName);
           // }
           // MarkaCBX.ItemsSource =dpmarka;


           // string querymodel = "SELECT * FROM Model";
           // var datamodel = dbConnection.Query<Model.Models.Model>(querymodel);
           // List<string> dpmodel = new List<string>();
           // foreach (var item in datamodel)
           // {
           //     dpmodel.Add(item.ModelName);
           // }
           // ModelCBX.ItemsSource =dpmodel;



           // string queryacc = "SELECT * FROM AcceleratingBox";
           // var dataacc= dbConnection.Query<AcceleratingBox>(queryacc);
           // List<string> dpacc = new List<string>();
           // foreach (var item in dataacc)
           // {
           //     dpacc.Add(item.AcceleratingBox1);
           // }
           // AccBoxCBX.ItemsSource =dpacc;


           // string querycity = "SELECT * FROM City";
           // var datacity = dbConnection.Query<City>(querycity);
           // List<string> dpcity = new List<string>();
           // foreach (var item in datacity)
           // {
           //     dpcity.Add(item.Name);
           // }
           // CityCBX.ItemsSource =dpcity;



           // string queryColor = "SELECT * FROM Color";
           // var dataColor = dbConnection.Query<Model.Models.Color>(querycity);
           // List<string> dpColor = new List<string>();
           // foreach (var item in dataColor)
           // {
           //     dpColor.Add(item.Color1);
           // }
           // ColorTBX.ItemsSource =dpColor;



           // string queryFuelType = "SELECT * FROM FuelType";
           // var dataFuelType = dbConnection.Query<Model.Models.FuelType>(queryFuelType);
           // List<string> dpFuelType = new List<string>();
           // foreach (var item in dataFuelType)
           // {
           //     dpFuelType.Add(item.FuelType1);
           // }
           // fUELTYPETBX.ItemsSource =dpFuelType;









        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Page1 page1 = new Page1();
            mainFrame.Content = page1;
            mainFrame.Visibility =(Visibility.Visible);
            DateTime dateTime = DateTime.Now;

        }

        private void MarkaCBX_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedMarkaname = MarkaCBX.SelectedItem.ToString();
            Marka marka = new Marka();
            foreach (var item in Context.Markas.ToList())
            {
                if (item.MarkaName==selectedMarkaname)
                {
                    marka = item;
                }
            }
            if (marka != null)
            {
                int selectedMarkaID = marka.Id+2;
                var filteredModeller = Context.Models.Where(m => m.MarkaId == selectedMarkaID).ToList();
                List<string> bzmaasa = new List<string>();
                foreach (var item in filteredModeller)
                {
                    bzmaasa.Add(item.ModelName);
                }
                ModelCBX.ItemsSource = bzmaasa;
            }
        }
    }
}
