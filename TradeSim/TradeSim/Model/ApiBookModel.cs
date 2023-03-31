using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RetrieveApiDataSample.Model
{
    public class ApiBookModel
    {
        public int cover_i { get; set; }
        public bool has_fulltext { get; set; }
        public int edition_count { get; set; }
        public string title { get; set; }
        public List<string> author_name { get; set; }
        public string key { get; set; }
        public List<string> ia { get; set; }
        public List<string> author_key { get; set; }
        public bool public_scan_b { get; set; }
    }
}
