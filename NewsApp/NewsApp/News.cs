using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace NewsApp
{
    class News
    {

        //get general news
        public async static Task<RootObject> GetNews()
        {
            var http = new HttpClient();
            //var response = await http.GetAsync("https://newsapi.org/v2/everything?q=Apple&from=2018-02-26&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");
            var response = await http.GetAsync("https://newsapi.org/v2/top-headlines?language=en&country=ie&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");

            var result = await response.Content.ReadAsStringAsync();
            //var serializer = new DataContractJsonSerializer(typeof(RootObject));

            //var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            //var data = (RootObject)serializer.ReadObject(ms);


            //deserialize the json object
            var data = JsonConvert.DeserializeObject<RootObject>(result);

            return data;
        }

        //get technology news
        public async static Task<RootObject> GetTechNews()
        {
            var http = new HttpClient();
            //var response = await http.GetAsync("https://newsapi.org/v2/everything?q=Apple&from=2018-02-26&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");
            var response = await http.GetAsync("https://newsapi.org/v2/top-headlines?language=en&country=ie&category=technology&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");

            var result = await response.Content.ReadAsStringAsync();
            //var serializer = new DataContractJsonSerializer(typeof(RootObject));

            //var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            //var data = (RootObject)serializer.ReadObject(ms);


            //deserialize the json objec
            var data = JsonConvert.DeserializeObject<RootObject>(result);

            return data;
        }

        //get sport news
        public async static Task<RootObject> GetSportNews()
        {
            var http = new HttpClient();
            //var response = await http.GetAsync("https://newsapi.org/v2/everything?q=Apple&from=2018-02-26&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");
            var response = await http.GetAsync("https://newsapi.org/v2/top-headlines?language=en&country=ie&category=sports&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");

            var result = await response.Content.ReadAsStringAsync();
            //var serializer = new DataContractJsonSerializer(typeof(RootObject));

            //var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            //var data = (RootObject)serializer.ReadObject(ms);


            //deserialize the json object
            var data = JsonConvert.DeserializeObject<RootObject>(result);

            return data;
        }


        //get science news
        public async static Task<RootObject> GetScienceNews()
        {
            var http = new HttpClient();
            //var response = await http.GetAsync("https://newsapi.org/v2/everything?q=Apple&from=2018-02-26&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");
            var response = await http.GetAsync("https://newsapi.org/v2/top-headlines?language=en&country=ie&category=science&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");

            var result = await response.Content.ReadAsStringAsync();
            //var serializer = new DataContractJsonSerializer(typeof(RootObject));

            //var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            //var data = (RootObject)serializer.ReadObject(ms);


            //deserialize the json object
            var data = JsonConvert.DeserializeObject<RootObject>(result);

            return data;
        }


        //get health news
        public async static Task<RootObject> GetHealthNews()
        {
            var http = new HttpClient();
            //var response = await http.GetAsync("https://newsapi.org/v2/everything?q=Apple&from=2018-02-26&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");
            var response = await http.GetAsync("https://newsapi.org/v2/top-headlines?language=en&country=ie&category=health&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");

            var result = await response.Content.ReadAsStringAsync();
            //var serializer = new DataContractJsonSerializer(typeof(RootObject));

            //var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            //var data = (RootObject)serializer.ReadObject(ms);


            //deserialize the json object
            var data = JsonConvert.DeserializeObject<RootObject>(result);

            return data;
        }


        //get entertainment news
        public async static Task<RootObject> GetEntertainmentNews()
        {
            var http = new HttpClient();
            //var response = await http.GetAsync("https://newsapi.org/v2/everything?q=Apple&from=2018-02-26&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");
            var response = await http.GetAsync("https://newsapi.org/v2/top-headlines?language=en&country=ie&category=entertainment&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");

            var result = await response.Content.ReadAsStringAsync();
            //var serializer = new DataContractJsonSerializer(typeof(RootObject));

            //var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            //var data = (RootObject)serializer.ReadObject(ms);


            //deserialize the json object
            var data = JsonConvert.DeserializeObject<RootObject>(result);

            return data;
        }


        //get business news
        public async static Task<RootObject> GetBusinessNews()
        {
            var http = new HttpClient();
            //var response = await http.GetAsync("https://newsapi.org/v2/everything?q=Apple&from=2018-02-26&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");
            var response = await http.GetAsync("https://newsapi.org/v2/top-headlines?language=en&country=ie&category=business&sortBy=popularity&apiKey=603e450543534137a9c174909d4ac4fe");

            var result = await response.Content.ReadAsStringAsync();
            //var serializer = new DataContractJsonSerializer(typeof(RootObject));

            //var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            //var data = (RootObject)serializer.ReadObject(ms);


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
            currentNews = "Source-"  + source.ToString() + "\n"  + "Author-" + author + "\n" + "Title-" + title + "\n" +
                "Description-" + description +"\n" +"Url-"+ url + "\n"  + "Image-" + urlToImage + "\n" +
                "Published at-"+ publishedAt + "\n\n\n";
            return currentNews;
        }

        // public override string ToString()
        //{
        //    return author;
        //        //Debug.WriteLine(author);
        //}
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

        //public override string ToString()
        //{
        //    // Returns vars from articles class
        //    //  return string.Format("{0}", string.Join("", articles.ToString()));
        //    return articles.ToString();

       //overiride ToString method on root object

       //to return the full news object as a string
        override
            public String ToString()
        {
            var obectString = "";
            foreach (var myArty in articles)
            {
                obectString = "\n" + obectString + myArty.ToString();
            }
            return obectString;
        }

        //to return only author
        public String returnAuthor()
        {
            var obectString = "";
            foreach (var myArty in articles)
            {
                obectString = "\n" + obectString + "AUTHOR - " + myArty.author + "\n";
            }
            return obectString;
        }

        //to return only title
        public String returnTitle()
        {
            var obectString = "";
            foreach (var myArty in articles)
            {
                obectString = "\n" + obectString + "TITLE - " + myArty.title + "\n";
            }
            return obectString;
        }

        //to return only url
        public String returnUrl()
        {
            var obectString = "";
            foreach (var myArty in articles)
            {
                obectString = "\n" + obectString + "URL - " + myArty.url + "\n";
            }
            return obectString;
        }

        //to return only urlImage
        public String returnUrlImage()
        {
            var obectString = "";
            foreach (var myArty in articles)
            {
                obectString = "\n" + obectString + "URLIMAGE - " + myArty.urlToImage + "\n";
            }
            return obectString;
        }


        //to return only publish date
        public String returnPublishedAt()
        {
            var obectString = "";
            foreach (var myArty in articles)
            {
                obectString = "\n" + obectString + "PUBLISHEDAT - " + myArty.publishedAt + "\n";
            }
            return obectString;
        }


        //to return only source
        public String returnSource()
        {
            var obectString = "";
            foreach (var myArty in articles)
            {
                obectString = "\n" + obectString + "PUBLISHEDAT - " + myArty.source + "\n";
            }
            return obectString;
        }



        //to return only description
        public String returnDescription()
        {
            var obectString = "";
            foreach (var myArty in articles)
            {
                obectString = "\n" + obectString + "SOURCE- " + myArty.description + "\n";
            }
            return obectString;
        }
        //}
    }



}
