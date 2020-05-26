using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Medias
    {
        public int ID { get; set; }
        public string Path { get; set; }

        [DataType(DataType.Date)]
        public DateTime Add_date { get; set; }
    }
}
