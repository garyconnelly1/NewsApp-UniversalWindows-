using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace NewsApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //outPutData();
        }

        private async void outPutData()
        {
            RootObject myNews = await News.GetNews();
            Debug.WriteLine(myNews.ToString());

        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myNews = await News.GetNews();
            NewsTextBlock.Text = myNews.ToString();
            // outPutData();
        }

        private void GetName_Button_Click(object sender, RoutedEventArgs e)
        {
            //String name = "Gary";
            //MessageBox.Show("Your name is: " + name);
            // NameTextBlock.Text = name;
        }

        private async void GetTechNews_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myTechNews = await News.GetTechNews();
            TechNewsTextBlock.Text = myTechNews.ToString();
        }

        private async void GetSportNews_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject mySportNews = await News.GetSportNews();
            SportNewsTextBlock.Text = mySportNews.ToString();

        }

        private async void GetScienceNews_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myScienceNews = await News.GetScienceNews();
            ScienceNewsTextBlock.Text = myScienceNews.ToString();
        }

        private async void GetHealthNews_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myHealthNews = await News.GetHealthNews();
            HealthNewsTextBlock.Text = myHealthNews.ToString();

        }

        private async void GetEntertainmentNews_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myEntertainmentNews = await News.GetEntertainmentNews();
            EntertainmentNewsTextBlock.Text = myEntertainmentNews.ToString();
        }

        private async void GetBusinessNews_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myBusinessNews = await News.GetBusinessNews();
            EntertainmentNewsTextBlock.Text = myBusinessNews.ToString();
        }
    }
}
