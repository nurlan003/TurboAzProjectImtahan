using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
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
    
    public partial class Page1 : Page
    {

        TurboAzContext context = new TurboAzContext();



        public Page1()
        {
            InitializeComponent();
            List<string> bzmarka = new List<string>();
            foreach (var marka in context.Markas.ToList())
            {
                bzmarka.Add(marka.MarkaName);
            }
            MarkasCB.ItemsSource = bzmarka;

            List<string> bzcolor = new List<string>();
            foreach (var color in context.Colors.ToList())
            {
                bzcolor.Add(color.Color1);
            }
            ColorsCB.ItemsSource = bzcolor;

            List<string> bzfuel = new List<string>();
            foreach (var fuel in context.FuelTypes.ToList())
            {
                bzfuel.Add(fuel.FuelType1);
            }
            FuelsCB.ItemsSource = bzfuel;

            List<string> bzcity = new List<string>();
            foreach (var citya in context.Cities.ToList())
            {
                bzcity.Add(citya.Name);
            }
            CitysCB.ItemsSource = bzcity;


            List<string> bzacc = new List<string>();
            foreach (var acc in context.AcceleratingBoxes.ToList())
            {
                bzacc.Add(acc.AcceleratingBox1);
            }
            ACCCB.ItemsSource = bzacc;


            List<string> bztrr = new List<string>();
            foreach (var transmitter in context.Transmitters.ToList())
            {
                bztrr.Add(transmitter.CarTransmitter);
            }
            transmitterCB.ItemsSource = bztrr;

            List<int> bzyear = new List<int>();
            foreach (var year in context.Years.ToList())
            {
                bzyear.Add(year.Year1.Year);
            }
            yearsCB.ItemsSource = bzyear;


            //Dapper
            //string connectionString = "Data Source=NURLANJAVADZADA;Initial Catalog=TurboAz;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            //using IDbConnection dbConnection = new SqlConnection(connectionString);


            //string querymarka = "SELECT * FROM Marka";
            //var datamarka = dbConnection.Query<Marka>(querymarka);
            //List<string> dpmarka = new List<string>();
            //foreach (var item in datamarka)
            //{
            //    dpmarka.Add(item.MarkaName);
            //}
            //MarkasCB.ItemsSource =dpmarka;


            //string querymodel = "SELECT * FROM Model";
            //var datamodel = dbConnection.Query<Model.Models.Model>(querymodel);
            //List<string> dpmodel = new List<string>();
            //foreach (var item in datamodel)
            //{
            //    dpmodel.Add(item.ModelName);
            //}
            //ModelsCB.ItemsSource =dpmodel;



            //string queryacc = "SELECT * FROM AcceleratingBox";
            //var dataacc = dbConnection.Query<AcceleratingBox>(queryacc);
            //List<string> dpacc = new List<string>();
            //foreach (var item in dataacc)
            //{
            //    dpacc.Add(item.AcceleratingBox1);
            //}
            //ACCCB.ItemsSource =dpacc;


            //string querycity = "SELECT * FROM City";
            //var datacity = dbConnection.Query<City>(querycity);
            //List<string> dpcity = new List<string>();
            //foreach (var item in datacity)
            //{
            //    dpcity.Add(item.Name);
            //}
            //CitysCB.ItemsSource =dpcity;



            //string queryColor = "SELECT * FROM Color";
            //var dataColor = dbConnection.Query<Model.Models.Color>(querycity);
            //List<string> dpColor = new List<string>();
            //foreach (var item in dataColor)
            //{
            //    dpColor.Add(item.Color1);
            //}
            //ColorsCB.ItemsSource =dpColor;



            //string queryFuelType = "SELECT * FROM FuelType";
            //var dataFuelType = dbConnection.Query<Model.Models.FuelType>(queryFuelType);
            //List<string> dpFuelType = new List<string>();
            //foreach (var item in dataFuelType)
            //{
            //    dpFuelType.Add(item.FuelType1);
            //}
            //FuelsCB.ItemsSource =dpFuelType;

            //string queryYear = "SELECT * FROM Year";
            //var dataYear = dbConnection.Query<Model.Models.Year>(queryFuelType);
            //List<DateTime> dpYear = new List<DateTime>();
            //foreach (var item in dataYear)
            //{
            //    dpYear.Add(item.Year1);
            //}
            //yearsCB.ItemsSource =dpYear;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Car car = new Car();

            Marka marka = new Marka();
            Model.Models.Model model = new TurboAzProject.Model.Models.Model();
            AcceleratingBox acceleratingBox = new AcceleratingBox();
            City city = new City();
            Model.Models.Color color = new Model.Models.Color();
            Engine engine = new Engine();
            FuelType fuelType = new FuelType();
            March march = new March();
            Price price = new Price();
            RegistrationPlate registrationPlate = new RegistrationPlate();
            Transmitter transmitter = new Transmitter();
            Year year = new Year();
            Model.Models.Image image = new Model.Models.Image();

            marka.MarkaName = MarkasCB.SelectedItem.ToString();

            model.ModelName = ModelsCB.SelectedItem.ToString();
            model.MarkaId =2;

            acceleratingBox.AcceleratingBox1 = ACCCB.SelectedItem.ToString();

            transmitter.CarTransmitter = transmitterCB.SelectedItem.ToString();

            color.Color1 = ColorsCB.SelectedItem.ToString();

            city.Name = CitysCB.SelectedItem.ToString();

            engine.Engine1 = int.Parse(engineTXT.Text);

            fuelType.FuelType1 = FuelsCB.SelectedItem.ToString();

            price.CarPrice = int.Parse(priceTXT.Text);

            registrationPlate.RegistrationPlate1 = regiTXT.Text;

            year.Year1 = DateTime.Now;

            march.CarMarch = int.Parse(MarchTXT.Text);
            image.ImagePath =ImageTXT.Text;

            car.AcceleratingBox = acceleratingBox;
            car.Marka = marka;
            car.Model = model;
            car.Transmitter = transmitter;
            car.Color = color;
            car.City = city;
            car.Engine = engine;
            car.FuelType = fuelType;
            car.Price = price;
            car.RegistrationPlate = registrationPlate;
            car.Year = year;
            car.March = march;
            car.Image = image;
            context.Cars.Add(car);
            context.SaveChanges();


            this.Visibility = Visibility.Hidden;
        }

        private void MarkasCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedMarkaname = MarkasCB.SelectedItem.ToString();
            Marka marka = new Marka();
            foreach (var item in context.Markas.ToList())
            {
                if (item.MarkaName==selectedMarkaname)
                {
                    marka = item;
                }
            }
            if (marka != null)
            {
                int selectedMarkaID = marka.Id+2;
                var filteredModeller = context.Models.Where(m => m.MarkaId == selectedMarkaID).ToList();
                List<string> bzmaasa = new List<string>();
                foreach (var item in filteredModeller)
                {
                    bzmaasa.Add(item.ModelName);
                }
                ModelsCB.ItemsSource = bzmaasa;
            }
        }
    }
}


