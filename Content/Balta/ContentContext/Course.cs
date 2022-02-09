using System.Collections.Generic;

namespace Balta.ContentContext
{
    public class Course : Content
    {
        public Course()
        {

        }

        public string Tag { get; set; }

        public IList<Module> Modules { get; set; }

    }

    public class Module
    {

    }
}