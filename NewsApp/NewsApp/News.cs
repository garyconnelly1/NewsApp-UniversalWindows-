using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace NewsApp
{
    class News
    {
        public string theCountry { get; set; }
        public int i { get; set; }
        // string theCountry = "x";
        static string country = "ie";
        /*
        public void setCountry(string myCountry)
        {
            this.theCountry = myCountry;
        }
        */

        public string switchCountry(string country)
        {
           // MainPage main = new MainPage();
           // theCountry = main.theCountrySelected;
            Debug.WriteLine("switch country + " + country);

            

            //switch theCountry
            switch (country)
            {
                case "Argentina":
                    country = "ar";
                    theCountry = "ar";
                    break;

                case "Austrailia":
                    country = "au";
                    break;

                case "Brazil":
                    country = "br";
                    break;

                case "Canada":
                    country = "ca";
                    break;

                case "Egypt":
                    country = "eg";
                    break;

                case "Germany":
                    country = "de";
                    break;

                case "Poland":
                    country = "pl";
                    break;

                case "Russia":
                    country = "ru";
                    break;

                case "South Korea":
                    country = "kr";
                    break;

                case "Sweden":
                    country = "se";
                    break;

                case "France":
                    country = "fr";
                    break;

                case "Ireland":
                    country = "ie";
                    break;

                case "UK":
                    country = "gb";
                    break;

                case "US":
                    country = "us";
                    break;

                default:
                    country = "ie";
                    break;
            }


            return country;

        }//end get country

        //get general news
        public async static Task<RootObject> GetNews(string countryEntered)
        {
            News news = new News();
            Debug.WriteLine("The country + " + news.theCountry);
            string countryQuery = news.switchCountry(countryEntered);
            news.theCountry = countryQuery;
           
            Debug.WriteLine("The After country + " + news.theCountry + news.i);
           

            Debug.WriteLine("Get News + " + countryQuery);
            var http = new HttpClient();
           
           // var countryQuery = news.getCountry();
          //  Debug.WriteLine(countryQuery);
           // var query1 = "https://newsapi.org/v2/top-headlines?language=en&country=";
           // var query2 = "&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe";
           // var query = query1 + query2 + country;
            //var response = await http.GetAsync("https://newsapi.org/v2/everything?q=Apple&from=2018-02-26&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");
            var response = await http.GetAsync("https://newsapi.org/v2/top-headlines?language=en&country=" + countryQuery +  "&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");
          

            var result = await response.Content.ReadAsStringAsync();
            
            //deserialize the json object
            var data = JsonConvert.DeserializeObject<RootObject>(result);

            return data;
        }

        //get technology news
        public async static Task<RootObject> GetTechNews(string countryEntered)
        {
            News news = new News();
            var http = new HttpClient();
            var countryQuery = news.switchCountry(countryEntered);
            Debug.WriteLine("Tech news + " + countryQuery);
           // Debug.WriteLine("Tech news + " + countryQuery + news.i);
            //var response = await http.GetAsync("https://newsapi.org/v2/everything?q=Apple&from=2018-02-26&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");
            var response = await http.GetAsync("https://newsapi.org/v2/top-headlines?language=en&country=" + countryQuery + "&category=technology&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");

            var result = await response.Content.ReadAsStringAsync();
           
            //deserialize the json objec
            var data = JsonConvert.DeserializeObject<RootObject>(result);

            return data;
        }

        //get sport news
        public async static Task<RootObject> GetSportNews(string countryEntered)
        {
            News news = new News();
            var http = new HttpClient();

            var countryQuery = news.switchCountry(countryEntered);
            Debug.WriteLine("Sport news + " + countryQuery);
            //var response = await http.GetAsync("https://newsapi.org/v2/everything?q=Apple&from=2018-02-26&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");
            var response = await http.GetAsync("https://newsapi.org/v2/top-headlines?language=en&country=" + countryQuery + "&category=sports&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");

            var result = await response.Content.ReadAsStringAsync();
            
            //deserialize the json object
            var data = JsonConvert.DeserializeObject<RootObject>(result);

            return data;
        }


        //get science news
        public async static Task<RootObject> GetScienceNews(string countryEntered)
        {
            News news = new News();
            var http = new HttpClient();
            var countryQuery = news.switchCountry(countryEntered);
            Debug.WriteLine("Science news + " + countryQuery);
            //var response = await http.GetAsync("https://newsapi.org/v2/everything?q=Apple&from=2018-02-26&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");
            var response = await http.GetAsync("https://newsapi.org/v2/top-headlines?language=en&country=" + countryQuery + "&category=science&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");

            var result = await response.Content.ReadAsStringAsync();
           
            //deserialize the json object
            var data = JsonConvert.DeserializeObject<RootObject>(result);

            return data;
        }


        //get health news
        public async static Task<RootObject> GetHealthNews(string countryEntered)
        {
            News news = new News();
            var http = new HttpClient();
            var countryQuery = news.switchCountry(countryEntered);
            Debug.WriteLine("Health news + " + countryQuery);
            //var response = await http.GetAsync("https://newsapi.org/v2/everything?q=Apple&from=2018-02-26&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");
            var response = await http.GetAsync("https://newsapi.org/v2/top-headlines?language=en&country="+ countryQuery + "&category=health&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");

            var result = await response.Content.ReadAsStringAsync();
           
            //deserialize the json object
            var data = JsonConvert.DeserializeObject<RootObject>(result);

            return data;
        }


        //get entertainment news
        public async static Task<RootObject> GetEntertainmentNews(string countryEntered)
        {
            News news = new News();
            var http = new HttpClient();
            var countryQuery = news.switchCountry(countryEntered);
            Debug.WriteLine("Entertainment news + " + countryQuery);
            //var response = await http.GetAsync("https://newsapi.org/v2/everything?q=Apple&from=2018-02-26&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");
            var response = await http.GetAsync("https://newsapi.org/v2/top-headlines?language=en&country="+ countryQuery + "&category=entertainment&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");

            var result = await response.Content.ReadAsStringAsync();
            
            //deserialize the json object
            var data = JsonConvert.DeserializeObject<RootObject>(result);

            return data;
        }


        //get business news
        public async static Task<RootObject> GetBusinessNews(string countryEntered)
        {
            News news = new News();
            var http = new HttpClient();
            var countryQuery = news.switchCountry(countryEntered);
            Debug.WriteLine("Business news + " + countryQuery);
            //var response = await http.GetAsync("https://newsapi.org/v2/everything?q=Apple&from=2018-02-26&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");
            var response = await http.GetAsync("https://newsapi.org/v2/top-headlines?language=en&country="+ countryQuery + "&category=business&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");

            var result = await response.Content.ReadAsStringAsync();
           
            //deserialize the json object
            var data = JsonConvert.DeserializeObject<RootObject>(result);

            return data;
        }
    }


    //from json2csharp website
    [DataContract]
    public class Source
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string name { get; set; }

        override
           public String ToString()
        {
            var mySource = name;

            return mySource;

        }
    }

    [DataContract]
    public class Article
    {
        [DataMember]
        public Source source { get; set; }
        [DataMember]
        public string author { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string urlToImage { get; set; }
        [DataMember]
        public DateTime publishedAt { get; set; }

        override
            public String ToString()
        {
            var currentNews = "";
            currentNews = "SOURCE- "  + source.ToString() + "\n"  + "AUTHOR- " + author + "\n" + "TITLE- " + title + "\n" +
                "DESCRIPTION- " + description +"\n" + "PUBLISHED AT- "+ publishedAt;
            return currentNews;
        }
    }

    [DataContract]
    public class RootObject
    {
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public int totalResults { get; set; }
        [DataMember]
        public List<Article> articles { get; set; }

       
        override
            public String ToString()
        {
            var obectString = "";
            foreach (var myArty in articles)
            {
                //use object string array for links ie [0] = image [1] = article link [3] = article info
                obectString = "\n" + obectString + myArty.ToString();
            }
            return obectString;
        }

        //to return only author
        public List<string> returnArticleList()
        {
            var obectString = "";
            List<string> myList = new List<string>();
            foreach (var myArty in articles)
            {
                obectString = "\n" +  myArty.url + "\n" + myArty.urlToImage + "\n" + myArty.ToString();
                myList.Add(obectString);
            }
            return myList;
        }

        //to return only author
        public List<string[]> returnArticleListArray()
        {
            // var obectString = "";
            string[] obectString = new string[3];
            List<string[]> myList = new List<string[]>();
            foreach (var myArty in articles)
            {
               
                obectString[0] = "\n  YURT "  + myArty.url;
                obectString[1] = "\n" + myArty.ToString();
                myList.Add(obectString);
            }
            return myList;
        }
    }
}
