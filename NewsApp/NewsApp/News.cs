using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp
{
    class News
    {
    }


    //from json2csharp website
    [DataContract]
    public class Source
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string name { get; set; }
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
            currentNews = "Author-" + author + "\n" + "Title-" + title + "\n" + "Description" + description + "\n";
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
