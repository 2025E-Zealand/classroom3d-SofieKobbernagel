// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

Console.WriteLine("Hello, World!");

ClassRoom class1 = new ClassRoom("3D",new DateTime(2025,08,04,09,10,00));
class1.StudentList.Add(new Student("Sofie", 9, 4));
class1.StudentList.Add(new Student("Lars", 5, 12));
class1.StudentList.Add(new Student("Klaus", 11, 23));
class1.StudentList.Add(new Student("Anna", 3, 15));