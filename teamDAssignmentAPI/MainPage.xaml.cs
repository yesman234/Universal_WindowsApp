using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using teamDAssignmentAPI.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace teamDAssignmentAPI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Getdata();
        }
        async void Getdata()
        {
            string url = "https://samples.openweathermap.org/data/2.5/weather?zip=94040,us&appid=b2e71bc92bd20bab9d73e139235100a8";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<Rootobject>(response);
            result_lbl.Text = data.main.temp.ToString()+"'C";
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

       
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
