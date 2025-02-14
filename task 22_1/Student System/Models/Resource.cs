using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentsSystem.Models
{
    internal class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public enum ResourceType
        {
            Video ,
            Presentation ,
            Document ,
            Other
        }
        public ResourceType resourceType { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public List<Homework> homeworks { get; set; }

    }
}
