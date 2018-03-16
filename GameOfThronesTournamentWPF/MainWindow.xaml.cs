using EntitiesLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

using Newtonsoft.Json;
using Microsoft.Win32;
using System.Xml.Serialization;
using System.IO;

namespace GameOfThronesTournamentWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void ShowHouses_Click(object sender, RoutedEventArgs e)
        {
            List<HouseDTO> houses = new List<HouseDTO>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:11526/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/house/");
                if(response.IsSuccessStatusCode)
                {
                    string temp = await response.Content.ReadAsStringAsync();
                    houses = JsonConvert.DeserializeObject<List<HouseDTO>>(temp);
                }
            }

            ResList.ItemsSource = houses;
        }

        private async void ShowChars_Click(object sender, RoutedEventArgs e)
        {
            List<CharacterDTO> characters = new List<CharacterDTO>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:11526/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/character/");
                if (response.IsSuccessStatusCode)
                {
                    string temp = await response.Content.ReadAsStringAsync();
                    characters = JsonConvert.DeserializeObject<List<CharacterDTO>>(temp);
                }
            }

            ResList.ItemsSource = characters;
        }

        private async void ShowWars_Click(object sender, RoutedEventArgs e)
        {
            List<FightDTO> fights = new List<FightDTO>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:11526/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/fight/");
                if (response.IsSuccessStatusCode)
                {
                    string temp = await response.Content.ReadAsStringAsync();
                    fights = JsonConvert.DeserializeObject<List<FightDTO>>(temp);
                }
            }

            ResList.ItemsSource = fights;
        }

        private void Sho(object sender, RoutedEventArgs e)
        {

        }

        private async void Export_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                List<HouseDTO> houses = new List<HouseDTO>();

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:11526/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync("api/house/");
                    if (response.IsSuccessStatusCode)
                    {
                        string temp = await response.Content.ReadAsStringAsync();
                        houses = JsonConvert.DeserializeObject<List<HouseDTO>>(temp);
                    }
                }

                XmlSerializer serializer = new XmlSerializer(typeof(List<HouseDTO>));

                using (StreamWriter wr = new StreamWriter(saveFileDialog.FileName))
                {
                    serializer.Serialize(wr, houses);
                }

                MessageBox.Show("List of houses saved !");
            }
        }
    }
}
