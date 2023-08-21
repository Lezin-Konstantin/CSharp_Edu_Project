// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write name");

String? Name = Console.ReadLine();
Console.WriteLine("Write age");
String AgeString = Console.ReadLine();

int Age = Int32.Parse(AgeString);

ApplicationContext db = new ApplicationContext();




    // создаем два объекта User
    Users NewUser = new Users { Name = Name, Age = Age};


// добавляем их в бд
//db.Users.Add(NewUser);

var FindedUser = db.Users.Where(p => p.Name == Name && p.Age == Age);

Console.WriteLine(FindedUser.Count());
int FindedUserCoun = FindedUser.Count();
if (FindedUserCoun == 0)
{
    Console.WriteLine("User can not find");
}

else
{

    foreach (Users user in FindedUser)
    {
        db.Users.Remove(user);
        Console.WriteLine("User Deleted");
    }
}


   
    db.SaveChanges();
    Console.WriteLine("Объекты успешно сохранены");

    // получаем объекты из бд и выводим на консоль
    var users = db.Users.ToList();
    Console.WriteLine("Список объектов:");
    foreach (Users u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }



String? AnyVar = Console.ReadLine();