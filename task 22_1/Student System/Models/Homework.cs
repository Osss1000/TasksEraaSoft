﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentsSystem.Models
{
    internal class Homework
    {
        public int HomeworkId { get; set; }
        public string Content { get; set; }
        public enum ContentType
        {
            Application ,
            Pdf ,
            Zip
        }
        public ContentType contentType { get; set; }
        public DateTime SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
