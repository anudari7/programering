using School_v2;

Console.WriteLine("School Info:");
School school1 = new School();
school1.Name = "Jensen Norra";
school1.Adress = "Tulegatan 44, 113 53 Stockholm";
school1.TotalTeachers = "26";
school1.TotalStudents = "500";

Console.WriteLine(school1.Name);
Console.WriteLine(school1.Adress);
Console.WriteLine(school1.TotalStudents);
Console.WriteLine(school1.TotalTeachers);
