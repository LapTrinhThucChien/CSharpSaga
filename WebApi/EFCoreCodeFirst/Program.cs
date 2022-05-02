// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using EFCoreCodeFirst.Context;
using EFCoreCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

var schoolDbContext = new SchoolContext();
//linq
//var student = schoolDbContext.Students;
//var grade = schoolDbContext.Grades.Where(s => s.GradeName == "Class 1")
//    .Include(g => g.Students).FirstOrDefault();

//eager loading => loadd all entites (entity, related entity)

//lazy loading
//grade => grade , students not load
var grade = schoolDbContext.Grades.FirstOrDefault(s => s.GradeName == "Class 1");

var studentList = grade?.Students;

//grade.student => load data

//var gradeId = grade?.Id; //grade = null => grade?.Id = null

//var studentList = schoolDbContext.Students.Where(x => x.GradeId == gradeId).ToList();
//1 câu sql query

//query linq

//var x = grade.Id; //grade = null => exception
//if (gradeId != null)
//    gradeId = grade.Id;

//Load student list
//var student = schoolDbContext.Entry(grade).Collection(s => s.Students).Query()
//    .Where(s => s.FirstName == "Bill")
//    .FirstOrDefault();

//var StudentList = grade?.Students;

//var studentList = grade?.Students?.ToList();

//Ưu điểm code first: 
//Toàn bộ với code c#: create database, create table, columns,
//set attribute, insert, update, delete. //database

Console.ReadLine();

