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


            //deserialize the json object
            var data = JsonConvert.DeserializeObject<RootObject>(result);

            return data;
        }

        //get technology news
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

        // kevin the great
        override
            public String ToString()
        {
            var gary = "";
            foreach (var myArty in articles)
            {
                gary = "\n" + gary + myArty.ToString();
            }
            return gary;
        }
        //}
    }



}
