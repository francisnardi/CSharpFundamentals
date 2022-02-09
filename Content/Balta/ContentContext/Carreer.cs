using System.Collections.Generic;

namespace Balta.ContentContext
{
    public class Carreer : Content
    {
        public Carreer(string title, string url) : base(title, url)
        {
            Items = new List<CarreerItem>();
        }
        public IList<CarreerItem> Items { get; set; }
        public int TotalCourses => Items.Count;

    }
}