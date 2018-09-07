using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryDbManager
{
    class BookSearchData
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
    }
}
