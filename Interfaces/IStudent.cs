﻿using ASPNETCore_DB.Models;

namespace ASPNETCore_DB.Interfaces
{
    public interface IStudent
    {
        IQueryable<Student> GetStudents(string searchString, string sortOrder);
        Student Details(string id);
        Student Create(Student student);
        Student ByEmail(string id);
        Student Edit(Student student);
        bool Delete(Student student);
        bool IsExist(string id);
        //object ByEmail(string v);
    }
}
