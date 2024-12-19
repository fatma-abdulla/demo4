

#region AllFunction

void PrintName()
{
    Console.WriteLine("Fatma Alhees");

}

int TotalSum()
{
    int n1 = 5;
    int n2 = 5;
    int n3 = 7;
    int sum = n1 + n2 + n3;

    return sum;

}
double EmployeeSalary()
{
    double salary, bounes, sum;
    salary = 1000;
    bounes = 1000;
    sum = salary + bounes;
    return sum;

}
string FullName(string name)
{
    return "Welcom "+name;
}

int FindMax(int n1,int n2)
{

    if (n1 > n2)
    {
        return n1;
     
    }

    else
        

    return n2;
}

 
string FullInfo(string name , int age ,string gender)
{
    string msg;
    if (age >= 18)
    {
        if (gender == "m")
        {
            msg = "m" + name + "your age is:" + age;
        }
        else
        {
            {
                msg = "age g.t 18";
            }
            return msg;
        }
    }
    else { return "not valid"; }
    
}

#endregion
#region CallFunction 
PrintName();
Console.WriteLine("total: " + TotalSum());
Console.WriteLine("All Marks: " + TotalSum());
Console.WriteLine("--------------------");
double Totalsales = 100;
double Empsalary = EmployeeSalary();
double Final = Totalsales + Empsalary;
Console.WriteLine("Total salary ;  " + Final);
//Console.WriteLine("enter your full name ; " + FullName);
string n =  Console.ReadLine();
Console.WriteLine(FullName(n));
Console.WriteLine("--------------------");

Console.WriteLine("entwe value 1");
int vall= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter value 2");
int all = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("max is ; "+ FindMax(vall, all));

FullInfo("", 99, "m");


#endregion
