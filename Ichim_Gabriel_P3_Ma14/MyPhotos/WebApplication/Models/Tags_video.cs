using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Tags_video
    {
        public int ID { get; set; }
        public string Zone { get; set; }
        public string Person { get; set; }
        public string Event { get; set; }
        public string Automobile { get; set; }
        public string Other_tags { get; set; }
        public int Video_Id { get; set; }
    }
}
