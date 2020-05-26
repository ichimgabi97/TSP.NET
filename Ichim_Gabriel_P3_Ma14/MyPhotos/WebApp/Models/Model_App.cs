using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Model_App
    {
        public int ID { get; set; }
        public string Path { get; set; }

        [DataType(DataType.Date)]
        public DateTime Add_date { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Last_updated { get; set; }
        public string Zone { get; set; }
        public string Person { get; set; }
        public string Event { get; set; }
        public string Automobile { get; set; }
        public string Other_tags { get; set; }

    }
}
