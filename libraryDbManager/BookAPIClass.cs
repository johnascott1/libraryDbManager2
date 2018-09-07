using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using Google.Apis.Books.v1.Data;
using Google.Apis.Books.v1;
using Google.Apis.Services;




namespace libraryDbManager
{
    public class BookAPIClass
    {

        //public BooksService booksService;
        //public BookApiClass(string apiKey)
        //{
        //    _booksService = new BooksService(new BaseClientService.Initializer()
        //    {
        //        ApiKey = apiKey,
        //        ApplicationName = this.GetType().ToString()
        //    });
        //}
        //public BookAPIClass()
        //{
        //    booksService = new BooksService(new BaseClientService.Initializer()
        //    {
        //        //ApiKey = "AIzaSyDGTdhLmZXUvkoncKB6Ik9g-tC6jOXues8",
        //        //ApplicationName = this.GetType().ToString()
               

        //    });
        //}
        public Tuple<int?, List<VolumeInfo>> SearchMethod(string query, int? offset, int? count)
        {
            BooksService booksService = new BooksService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyDGTdhLmZXUvkoncKB6Ik9g-tC6jOXues8",
                ApplicationName = "libraryDBManager"


            });
            VolumesResource.ListRequest listquery = booksService.Volumes.List(query);

            listquery.MaxResults = count;
            listquery.StartIndex = offset;
            //List<VolumeData> books = new VolumeData();

            Volumes res = listquery.Execute();
            //String book = res.VolumeData.Title.ToString();
            //books.Title = book;
            // List<String> CategoryTest = new List<String>();

            List<VolumeInfo> books = res.Items.Select(b => new VolumeInfo
            {
                Id = b.Id,
                Title = b.VolumeInfo.Title,
                Subtitle = b.VolumeInfo.Subtitle,
                Authors = b.VolumeInfo.Authors.ToList(),
                Description = b.VolumeInfo.Description,
                PageCount = b.VolumeInfo.PageCount,
                IndustryIdentifiers = b.VolumeInfo.IndustryIdentifiers.ElementAt(0).Identifier.ToString(),
                PublicationDate = b.VolumeInfo.PublishedDate,
                Print = b.VolumeInfo.PrintType,
                Publisher = b.VolumeInfo.Publisher
            }).ToList();
            //new Tuple<int?, List<VolumeData>>(res.TotalItems, books);
            return new Tuple<int?, List<VolumeInfo>>(res.TotalItems, books);
            //string path = @"This PC\Documents\BookDataText.txt";
            //FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);


            //foreach (var item in res.Items)
            //{
            //    fs.Write(item, offset, count);
            //}
            //fs.Close();
            //public Dictionary<int?, List<VolumeInfo>> SearchMethod(string query, int? offset, int? count);
            //public void SearchMethod(string query, int offset, int count)
            //List<VolumeInfo> books = res.Items.Select(b => new VolumeInfo
            //{
            //    Id = b.Id,
            //    Title = b.VolumeInfo.Title,
            //    Subtitle = b.VolumeInfo.Subtitle,
            //    Description = b.VolumeInfo.Description,
            //    PageCount = b.VolumeInfo.PageCount
            //}).ToList();
            //String Id = b.Id;
            //String Title = b.Title;
            //String Subtitle = b.Subtitle;
            //String Description = b.Description;
            //PageCount = b.PageCount;


            //Dictionary<int?, List<VolumeInfo>> bookRecords = new Dictionary<int?, List<VolumeInfo>>();

            //return new Dictionary<int?, List<VolumeInfo>>();

            //key: ucuJMOOQ3kymnoE1iwG5g
            //secret: iJVTn0ZOCCaWYiWrwCuXGyc6WFuACmTkrPSPvZQmIT
        }
    }

    public class VolumeInfo
    {
        public string Id
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public string Subtitle
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public int? PageCount
        {
            get;
            set;
        }
        public List<string> Authors
        {
            get;
            set;
        }
        public String IndustryIdentifiers
        {
            get;
            set;
        }
        public String PublicationDate
        {
            get;
            set;
        }
        public String Print
        {
            get;
            set;
        }
        public string Genre
        {
            get;
            set;
        }
        public String Publisher
        {
            get;
            set;
        }
    }
}


