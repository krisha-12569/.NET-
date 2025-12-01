using lab3;
 
Student student1 = new Student();

Console.WriteLine("Enter name : ");
student1.Name = Console.ReadLine();
Console.WriteLine("Enter Rollno : ");
student1.rollno = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter marks : ");
student1.marks = Convert.ToInt32(Console.ReadLine());

student1.PrintData();

Student student2 = new Student();

Console.WriteLine("Enter name : ");
student2.Name = Console.ReadLine();
Console.WriteLine("Enter Rollno : ");
student2.rollno = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter marks : ");
student2.marks = Convert.ToInt32(Console.ReadLine());

student2.PrintData();