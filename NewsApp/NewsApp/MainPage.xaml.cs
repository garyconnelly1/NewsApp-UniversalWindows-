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
using Windows.UI.Xaml.Media.Imaging;
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

        //to get general news
        private async void button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myNews = await News.GetNews();

            // NewsTextBlock.Text = myNews.ToString();
            NewsTextBlock1.Text = myNews.ToString();
            NewsTextBlock1.TextWrapping = TextWrapping.Wrap;

            // outPutData();
        }

        //to get general news
        private async void GetList_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myNews = await News.GetNews();

            List<string> myArticles = new List<string>();
            var obectString = "";
            myArticles = myNews.returnArticleList();
            Uri uri;
            int i = 0;

            //  foreach (var myArty in myArticles)
            foreach (var myArty in myNews.articles)
            {
                //obectString = "\n" + obectString + "AUTHOR - " + myArty.author + "\n";
                // myList.Add(obectString);
               
                    i++;
                    obectString = "\n" + myArty.ToString();
                     String myImage = myArty.urlToImage;

                    uri = new Uri(myArty.url);

                //1st article
                    if (i == 1)
                    {
                       
                        String image = String.Format(myImage);
                        ResultImage1.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                        NewsTextBlock1.Text += "\n\n" + obectString;
                        //NewsTextBlock.
                        NewsTextBlock1.TextWrapping = TextWrapping.Wrap;

                    }

                    //2nd article
                    if (i == 2)
                    {
                       
                        String image = String.Format(myImage);
                        ResultImage2.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                        NewsTextBlock2.Text += "\n\n" + obectString;
                        //NewsTextBlock.
                        NewsTextBlock2.TextWrapping = TextWrapping.Wrap;

                    }

                //3rd article
                if (i == 3)
                {

                    String image = String.Format(myImage);
                    ResultImage3.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    NewsTextBlock3.Text += "\n\n" + obectString;
                    //NewsTextBlock.
                    NewsTextBlock3.TextWrapping = TextWrapping.Wrap;

                }

                //4th article
                if (i == 4)
                {

                    String image = String.Format(myImage);
                    ResultImage4.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    NewsTextBlock4.Text += "\n\n" + obectString;
                    //NewsTextBlock.
                    NewsTextBlock4.TextWrapping = TextWrapping.Wrap;

                }

                //1st article
                if (i == 5)
                {

                    String image = String.Format(myImage);
                    ResultImage5.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    NewsTextBlock5.Text += "\n\n" + obectString;
                    //NewsTextBlock.
                    NewsTextBlock5.TextWrapping = TextWrapping.Wrap;

                }



            }
        }

        //to get general news
        /*
        private async void TGetList_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myNews = await News.GetNews();

            List<string[]> myArticles = new List<string[]>();

            myArticles = myNews.returnArticleListArray();

            foreach (string[] myArty in myArticles)
            {
                //obectString = "\n" + obectString + "AUTHOR - " + myArty.author + "\n";
                // myList.Add(obectString);
                ImageNewsTextBlock1.Text = myArty[0];
                //  NewsTextBlock.Text = myNews.ToString();
                NewsTextBlock1.Text = myArty[1];
                ImageNewsTextBlock1.TextWrapping = TextWrapping.Wrap;
                NewsTextBlock1.TextWrapping = TextWrapping.Wrap;
            }
        }
        */

        private void GetName_Button_Click(object sender, RoutedEventArgs e)
        {
            //String name = "Gary";
            //MessageBox.Show("Your name is: " + name);
            // NameTextBlock.Text = name;
        }

        private async void GetTechNews_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myTechNews = await News.GetTechNews();
            List<string> myArticles = new List<string>();
            var obectString = "";
            myArticles = myTechNews.returnArticleList();
            Uri uri;
            int i = 0;

            //  foreach (var myArty in myArticles)
            foreach (var myArty in myTechNews.articles)
            {
                //obectString = "\n" + obectString + "AUTHOR - " + myArty.author + "\n";
                // myList.Add(obectString);

                i++;
                obectString = "\n" + myArty.ToString();
                String myImage = myArty.urlToImage;

                uri = new Uri(myArty.url);

                //1st article
                if (i == 1)
                {
                  
                    String image = String.Format(myImage);
                    TechImage.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    TechNewsTextBlock.Text += "\n\n" + obectString;
                    TechNewsTextBlock.TextWrapping = TextWrapping.Wrap;

                }

                //2nd article
                if (i == 2)
                {

                    String image = String.Format(myImage);
                    TechImage2.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    TechNewsTextBlock2.Text += "\n\n" + obectString;
                    TechNewsTextBlock2.TextWrapping = TextWrapping.Wrap;

                }

                //3rd article
                if (i == 3)
                {

                    String image = String.Format(myImage);
                    TechImage3.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    TechNewsTextBlock3.Text += "\n\n" + obectString;
                    TechNewsTextBlock3.TextWrapping = TextWrapping.Wrap;

                }

                //4th article
                if (i == 4)
                {

                    String image = String.Format(myImage);
                    TechImage4.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    TechNewsTextBlock4.Text += "\n\n" + obectString;
                    TechNewsTextBlock4.TextWrapping = TextWrapping.Wrap;

                }

                //1st article
                if (i == 5)
                {

                    String image = String.Format(myImage);
                    TechImage5.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    TechNewsTextBlock5.Text += "\n\n" + obectString;
                    TechNewsTextBlock5.TextWrapping = TextWrapping.Wrap;

                }



            }
        }
        /*
        //to get general news
        private async void GetList_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myNews = await News.GetNews();

            List<string> myArticles = new List<string>();
            var obectString = "";
            myArticles = myNews.returnArticleList();
            Uri uri;
            int i = 0;

            //  foreach (var myArty in myArticles)
            foreach (var myArty in myNews.articles)
            {
                //obectString = "\n" + obectString + "AUTHOR - " + myArty.author + "\n";
                // myList.Add(obectString);

                i++;
                obectString = "\n" + myArty.ToString();
                String myImage = myArty.urlToImage;

                uri = new Uri(myArty.url);

                //1st article
                if (i == 1)
                {

                    String image = String.Format(myImage);
                    ResultImage1.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    NewsTextBlock1.Text += "\n\n" + obectString;
                    //NewsTextBlock.
                    NewsTextBlock1.TextWrapping = TextWrapping.Wrap;

                }

                //2nd article
                if (i == 2)
                {

                    String image = String.Format(myImage);
                    ResultImage2.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    NewsTextBlock2.Text += "\n\n" + obectString;
                    //NewsTextBlock.
                    NewsTextBlock2.TextWrapping = TextWrapping.Wrap;

                }

                //3rd article
                if (i == 3)
                {

                    String image = String.Format(myImage);
                    ResultImage3.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    NewsTextBlock3.Text += "\n\n" + obectString;
                    //NewsTextBlock.
                    NewsTextBlock3.TextWrapping = TextWrapping.Wrap;

                }

                //4th article
                if (i == 4)
                {

                    String image = String.Format(myImage);
                    ResultImage4.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    NewsTextBlock4.Text += "\n\n" + obectString;
                    //NewsTextBlock.
                    NewsTextBlock4.TextWrapping = TextWrapping.Wrap;

                }

                //1st article
                if (i == 5)
                {

                    String image = String.Format(myImage);
                    ResultImage5.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    NewsTextBlock5.Text += "\n\n" + obectString;
                    //NewsTextBlock.
                    NewsTextBlock5.TextWrapping = TextWrapping.Wrap;

                }



            }
        }
        */

        private async void GetSportNews_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject mySportNews = await News.GetSportNews();
            SportNewsTextBlock.Text = mySportNews.ToString();
            SportNewsTextBlock.TextWrapping = TextWrapping.Wrap;

        }

        private async void GetScienceNews_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myScienceNews = await News.GetScienceNews();
            ScienceNewsTextBlock.Text = myScienceNews.ToString();
            ScienceNewsTextBlock.TextWrapping = TextWrapping.Wrap;
        }

        private async void GetHealthNews_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myHealthNews = await News.GetHealthNews();
            HealthNewsTextBlock.Text = myHealthNews.ToString();
            HealthNewsTextBlock.TextWrapping = TextWrapping.Wrap;

        }

        private async void GetEntertainmentNews_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myEntertainmentNews = await News.GetEntertainmentNews();
            EntertainmentNewsTextBlock.Text = myEntertainmentNews.ToString();
            EntertainmentNewsTextBlock.TextWrapping = TextWrapping.Wrap;
        }

        private async void GetBusinessNews_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myBusinessNews = await News.GetBusinessNews();
            BusinessNewsTextBlock.Text = myBusinessNews.ToString();
            BusinessNewsTextBlock.TextWrapping = TextWrapping.Wrap;
        }

        //to get general news
        async void Image_Loaded(object sender, RoutedEventArgs e)
        {

            RootObject myNews = await News.GetNews();

            // NewsTextBlock.Text = myNews.ToString();
            string[] text = myNews.returnUrlImage();
            for (int i = 0; i < text.Length; i++)
            {

                Image img = sender as Image;
                BitmapImage bitmapImage = new BitmapImage();
               
                img.Width = bitmapImage.DecodePixelWidth = 80; //natural px width of image source
                                                               // don't need to set Height, system maintains aspect ratio, and calculates the other
                                                               // dimension, so long as one dimension measurement is provided
                bitmapImage.UriSource = new Uri(img.BaseUri, text[i]);


                //  NewsTextBlock.Text += "\n " + text[i] + "\n ";
                // NewsTextBlock.Text = text[0] + "\n";
                // NewsTextBlock.TextWrapping = TextWrapping.Wrap;
            }
            // NewsT



            //Image img = sender as Image;
            //BitmapImage bitmapImage = new BitmapImage();
            //img.Width = bitmapImage.DecodePixelWidth = 80; //natural px width of image source
            //                                               // don't need to set Height, system maintains aspect ratio, and calculates the other
            //                                               // dimension, so long as one dimension measurement is provided
            //bitmapImage.UriSource = new Uri(img.BaseUri, "Images/myimage.png");
        }
    }
}
