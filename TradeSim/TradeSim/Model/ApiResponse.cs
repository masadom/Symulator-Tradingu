using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieveApiDataSample.Model
{
    public class ApiResponse
    {
        public int start { get; set; }
        public int num_found { get; set; }
        public List<ApiBookModel> docs { get; set; }
    }
}
