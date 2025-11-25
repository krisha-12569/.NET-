Console.WriteLine("Enter choice (1 for celsius to fah and 2 for fah to celsius): ");

int choice = Convert.ToInt32(Console.ReadLine());
 

if(choice == 1){
     Console.WriteLine("Enter temperature to convert celsius to fah : ");
     double c = Convert.ToDouble(Console.ReadLine());
     double f = (c *(9.0/5.0))+32;
     Console.WriteLine("Fahrenheit : "+f);
}
else if(choice ==2){
    Console.WriteLine("Enter temperature to convert fah to Cel : ");
     double f =  Convert.ToDouble(Console.ReadLine());
     double c = (f-32)*(5.0/9.0);
     Console.WriteLine("Celsius : "+c);
}