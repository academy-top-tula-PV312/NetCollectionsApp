using System.Collections.Generic;

//List<int> ints = new List<int>();


//ArrayList arrayList = new ArrayList();

//arrayList.Add(1000);
//arrayList.Add("Hello");
//arrayList.Add(new { Name = "Bob", Age = 25});
//arrayList.Add(true);



List<Employee> employees = new()
{
    new(){ Name = "Sammy", Age = 39 },
    new(){ Name = "Jimmy", Age = 42 },
    new(){ Name = "Tommy", Age = 21 },
    new(){ Name = "Billy", Age = 49 },
    new(){ Name = "Donny", Age = 31 },
};

foreach (var e in employees)
    Console.WriteLine(e);
Console.WriteLine();

employees.Sort((Employee e1, Employee e2) => e1.Age.CompareTo(e2.Age));

foreach (var e in employees)
    Console.WriteLine(e);




class Employee : IComparable<Employee> // IComparable
{
    public string Name { set; get; }
    public int Age { set; get; }

    public int CompareTo(Employee? other)
    {
        return this.Name.CompareTo(other.Name);
    }

    //public int CompareTo(object? obj)
    //{
    //    //return this.Name.CompareTo((obj as Employee).Name);
    //    return this.Age.CompareTo((obj as Employee).Age);
    //}

    public override string ToString()
    {
        return $"{Name} {Age}";
    }
}




