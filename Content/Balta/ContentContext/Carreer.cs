using System.Collections.Generic;

namespace Balta.ContentContext
{
    public class Carreer : Content
    {
        public Carreer()
        {
            Items = new List<CarreerItem>();
        }
        public IList<CarreerItem> Items { get; set; }
    }
}