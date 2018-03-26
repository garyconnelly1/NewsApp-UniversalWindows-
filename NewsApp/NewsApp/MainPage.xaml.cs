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
using Windows.UI.Xaml.Documents;
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
                    String url = myArty.url;

                    uri = new Uri(myArty.url);

                //1st article
                    if (i == 1)
                    {

                        if (myImage != null)
                        {
                            String image = String.Format(myImage);
                            ResultImage1.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                        }
                    else
                    {
                        //ResultImage1.Source = "Assets/download.html";
                    }
                    Uri myuri = new Uri(url);
                    link1.NavigateUri = myuri;
                    //https://docs.microsoft.com/en-us/uwp/api/Windows.UI.Xaml.Documents.Hyperlink
                    Run run = new Run();
                    run.Text = "View full article here";
                    link1.Inlines.Add(run);
                    // LinkTextBlock.Text = "See full article here";
                    
                        NewsTextBlock1.Text += "\n\n" + obectString;
                        //NewsTextBlock.
                        NewsTextBlock1.TextWrapping = TextWrapping.Wrap;

                    }

                    //2nd article
                    if (i == 2)
                    {

                        if (myImage != null)
                        {
                            String image = String.Format(myImage);
                            ResultImage2.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                        }

                        Uri myuri = new Uri(url);
                        link2.NavigateUri = myuri;
                        //https://docs.microsoft.com/en-us/uwp/api/Windows.UI.Xaml.Documents.Hyperlink
                        Run run = new Run();
                        run.Text = "View full article here";
                        link2.Inlines.Add(run);


                        NewsTextBlock2.Text += "\n\n" + obectString;
                        //NewsTextBlock.
                        NewsTextBlock2.TextWrapping = TextWrapping.Wrap;

                    }

                //3rd article
                if (i == 3)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        ResultImage3.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }

                    Uri myuri = new Uri(url);
                    link3.NavigateUri = myuri;
                    //https://docs.microsoft.com/en-us/uwp/api/Windows.UI.Xaml.Documents.Hyperlink
                    Run run = new Run();
                    run.Text = "View full article here";
                    link3.Inlines.Add(run);


                    NewsTextBlock3.Text += "\n\n" + obectString;
                    //NewsTextBlock.
                    NewsTextBlock3.TextWrapping = TextWrapping.Wrap;

                }

                //4th article
                if (i == 4)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        ResultImage4.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }

                    Uri myuri = new Uri(url);
                    link4.NavigateUri = myuri;
                    //https://docs.microsoft.com/en-us/uwp/api/Windows.UI.Xaml.Documents.Hyperlink
                    Run run = new Run();
                    run.Text = "View full article here";
                    link4.Inlines.Add(run);


                    NewsTextBlock4.Text += "\n\n" + obectString;
                    //NewsTextBlock.
                    NewsTextBlock4.TextWrapping = TextWrapping.Wrap;

                }

                //5th article
                if (i == 5)
                {
                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        ResultImage5.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }

                    Uri myuri = new Uri(url);
                    link5.NavigateUri = myuri;
                    //https://docs.microsoft.com/en-us/uwp/api/Windows.UI.Xaml.Documents.Hyperlink
                    Run run = new Run();
                    run.Text = "View full article here";
                    link5.Inlines.Add(run);
                    NewsTextBlock5.Text += "\n\n" + obectString;
                    //NewsTextBlock.
                    NewsTextBlock5.TextWrapping = TextWrapping.Wrap;

                }



            }
        }

        

        private void GetName_Button_Click(object sender, RoutedEventArgs e)
        {
            //String name = "Gary";
            //MessageBox.Show("Your name is: " + name);
            // NameTextBlock.Text = name;
        }

        //for tech news
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

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        TechImage.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }
                    TechNewsTextBlock.Text += "\n\n" + obectString;
                    TechNewsTextBlock.TextWrapping = TextWrapping.Wrap;

                }

                //2nd article
                if (i == 2)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        TechImage2.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }

                   
                    TechNewsTextBlock2.Text += "\n\n" + obectString;
                    TechNewsTextBlock2.TextWrapping = TextWrapping.Wrap;

                }

                //3rd article
                if (i == 3)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        TechImage3.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }

           
                    TechNewsTextBlock3.Text += "\n\n" + obectString;
                    TechNewsTextBlock3.TextWrapping = TextWrapping.Wrap;

                }

                //4th article
                if (i == 4)
                {
                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        TechImage4.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }
                   
                    TechNewsTextBlock4.Text += "\n\n" + obectString;
                    TechNewsTextBlock4.TextWrapping = TextWrapping.Wrap;

                }

                //5th article
                if (i == 5)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        TechImage5.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }

                   
                    TechNewsTextBlock5.Text += "\n\n" + obectString;
                    TechNewsTextBlock5.TextWrapping = TextWrapping.Wrap;

                }



            }
        }
        

        //for sport news
        private async void GetSportNews_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject mySportNews = await News.GetSportNews();


            List<string> myArticles = new List<string>();
            var obectString = "";
            myArticles = mySportNews.returnArticleList();
            Uri uri;
            int i = 0;

            //  foreach (var myArty in myArticles)
            foreach (var myArty in mySportNews.articles)
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
                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        SportImage.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }

                    
                    SportNewsTextBlock.Text += "\n\n" + obectString;
                    SportNewsTextBlock.TextWrapping = TextWrapping.Wrap;

                }

                //2nd article
                if (i == 2)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        SportImage2.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }

                   
                    SportNewsTextBlock2.Text += "\n\n" + obectString;
                    SportNewsTextBlock2.TextWrapping = TextWrapping.Wrap;

                }

                //3rd article
                if (i == 3)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        SportImage3.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }

                   
                    SportNewsTextBlock3.Text += "\n\n" + obectString;
                    SportNewsTextBlock3.TextWrapping = TextWrapping.Wrap;

                }

                //4th article
                if (i == 4)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        SportImage4.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }


                   
                    SportNewsTextBlock4.Text += "\n\n" + obectString;
                    SportNewsTextBlock4.TextWrapping = TextWrapping.Wrap;

                }

                //5th article
                if (i == 5)
                {


                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        SportImage5.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }

                   
                    SportNewsTextBlock5.Text += "\n\n" + obectString;
                    SportNewsTextBlock5.TextWrapping = TextWrapping.Wrap;

                }



            }
        }




       
        //for science news
        private async void GetScienceNews_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myScienceNews = await News.GetScienceNews();


            List<string> myArticles = new List<string>();
            var obectString = "";
            myArticles = myScienceNews.returnArticleList();
            Uri uri;
            int i = 0;

            //  foreach (var myArty in myArticles)
            foreach (var myArty in myScienceNews.articles)
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

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        ScienceImage.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }

                    
                    ScienceNewsTextBlock.Text += "\n\n" + obectString;
                    ScienceNewsTextBlock.TextWrapping = TextWrapping.Wrap;

                }

                //2nd article
                if (i == 2)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        ScienceImage2.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }

                   
                    ScienceNewsTextBlock2.Text += "\n\n" + obectString;
                    ScienceNewsTextBlock2.TextWrapping = TextWrapping.Wrap;

                }

                //3rd article
                if (i == 3)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        ScienceImage3.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }

                   
                    ScienceNewsTextBlock3.Text += "\n\n" + obectString;
                    ScienceNewsTextBlock3.TextWrapping = TextWrapping.Wrap;

                }

                //4th article
                if (i == 4)
                {


                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        ScienceImage4.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }


                   
                    ScienceNewsTextBlock4.Text += "\n\n" + obectString;
                    ScienceNewsTextBlock4.TextWrapping = TextWrapping.Wrap;

                }

                //5th article
                if (i == 5)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        ScienceImage5.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }

                   
                    ScienceNewsTextBlock5.Text += "\n\n" + obectString;
                    ScienceNewsTextBlock5.TextWrapping = TextWrapping.Wrap;

                }



            }
        }

        private async void GetHealthNews_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myHealthNews = await News.GetHealthNews();

            List<string> myArticles = new List<string>();
            var obectString = "";
            myArticles = myHealthNews.returnArticleList();
            Uri uri;
            int i = 0;

            //  foreach (var myArty in myArticles)
            foreach (var myArty in myHealthNews.articles)
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

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        HealthImage.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }


                    HealthNewsTextBlock.Text += "\n\n" + obectString;
                    HealthNewsTextBlock.TextWrapping = TextWrapping.Wrap;

                }

                //2nd article
                if (i == 2)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        HealthImage2.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }


                    HealthNewsTextBlock2.Text += "\n\n" + obectString;
                    HealthNewsTextBlock2.TextWrapping = TextWrapping.Wrap;


                }

                //3rd article
                if (i == 3)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        HealthImage3.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }


                    HealthNewsTextBlock3.Text += "\n\n" + obectString;
                    HealthNewsTextBlock3.TextWrapping = TextWrapping.Wrap;


                }

                //4th article
                if (i == 4)
                {


                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        HealthImage4.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }


                    HealthNewsTextBlock4.Text += "\n\n" + obectString;
                    HealthNewsTextBlock4.TextWrapping = TextWrapping.Wrap;


                }

                //5th article
                if (i == 5)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        HealthImage5.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }


                    HealthNewsTextBlock5.Text += "\n\n" + obectString;
                    HealthNewsTextBlock5.TextWrapping = TextWrapping.Wrap;


                }



            }

        }//end health

        private async void GetEntertainmentNews_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myEntertainmentNews = await News.GetEntertainmentNews();

            List<string> myArticles = new List<string>();
            var obectString = "";
            myArticles = myEntertainmentNews.returnArticleList();
            Uri uri;
            int i = 0;

            //  foreach (var myArty in myArticles)
            foreach (var myArty in myEntertainmentNews.articles)
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

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        EntertainmentImage.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }


                    EntertainmentNewsTextBlock.Text += "\n\n" + obectString;
                    EntertainmentNewsTextBlock.TextWrapping = TextWrapping.Wrap;

                }

                //2nd article
                if (i == 2)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        EntertainmentImage2.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }


                    EntertainmentNewsTextBlock2.Text += "\n\n" + obectString;
                    EntertainmentNewsTextBlock2.TextWrapping = TextWrapping.Wrap;


                }

                //3rd article
                if (i == 3)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        EntertainmentImage3.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }


                    EntertainmentNewsTextBlock3.Text += "\n\n" + obectString;
                    EntertainmentNewsTextBlock3.TextWrapping = TextWrapping.Wrap;


                }

                //4th article
                if (i == 4)
                {


                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        EntertainmentImage4.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }


                    EntertainmentNewsTextBlock4.Text += "\n\n" + obectString;
                    EntertainmentNewsTextBlock4.TextWrapping = TextWrapping.Wrap;


                }

                //5th article
                if (i == 5)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        EntertainmentImage5.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }


                    EntertainmentNewsTextBlock5.Text += "\n\n" + obectString;
                    EntertainmentNewsTextBlock5.TextWrapping = TextWrapping.Wrap;


                }



            }

        }//end entertainment

        private async void GetBusinessNews_Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myBusinessNews = await News.GetBusinessNews();

            List<string> myArticles = new List<string>();
            var obectString = "";
            myArticles = myBusinessNews.returnArticleList();
            Uri uri;
            int i = 0;

            //  foreach (var myArty in myArticles)
            foreach (var myArty in myBusinessNews.articles)
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

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        BusinessImage.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }


                    BusinessNewsTextBlock.Text += "\n\n" + obectString;
                    BusinessNewsTextBlock.TextWrapping = TextWrapping.Wrap;

                }

                //2nd article
                if (i == 2)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        BusinessImage2.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }


                    BusinessNewsTextBlock2.Text += "\n\n" + obectString;
                    BusinessNewsTextBlock2.TextWrapping = TextWrapping.Wrap;

                }

                //3rd article
                if (i == 3)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        BusinessImage3.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }


                    BusinessNewsTextBlock3.Text += "\n\n" + obectString;
                    BusinessNewsTextBlock3.TextWrapping = TextWrapping.Wrap;



                }

                //4th article
                if (i == 4)
                {


                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        BusinessImage4.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }


                    BusinessNewsTextBlock4.Text += "\n\n" + obectString;
                    BusinessNewsTextBlock4.TextWrapping = TextWrapping.Wrap;



                }

                //5th article
                if (i == 5)
                {

                    if (myImage != null)
                    {
                        String image = String.Format(myImage);
                        BusinessImage5.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                    }


                    BusinessNewsTextBlock5.Text += "\n\n" + obectString;
                    BusinessNewsTextBlock5.TextWrapping = TextWrapping.Wrap;



                }

            }

        }// end business

        
    }
}
