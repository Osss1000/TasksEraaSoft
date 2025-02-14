﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentsSystem.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegisteredOn {  get; set; }
        public DateTime? Birthday { get; set; }

        public List<StudentCourse> studentCourses { get; set; }
        public List<Homework> homeworks { get; set; }
    }
}
