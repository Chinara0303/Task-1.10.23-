using DomainLayer.Models;
using System.Reflection;
using Task.Controllers;

#region Account
AccountController accountController = new AccountController();
//accountController.Register();
#endregion

#region Indexleme
Book book1 = new Book()
{
    Id = 1,
    Name = "Anna Karenina",
};
Book book2 = new Book()
{
    Id = 2,
    Name = "Qurur ve qerez",
};

Library library = new Library();
library[0] = book1;
library[1] = book2;

//Console.WriteLine($"{library[0].Name} {library[1].Name}");
#endregion

#region Assembly

Assembly assembly = Assembly.GetExecutingAssembly();
foreach (var item in assembly.GetTypes())
{
    //Console.WriteLine(item.Name);
    foreach (var item2 in item.GetMembers())
    {
        //Console.WriteLine(item2.Name);
    }
}
#endregion

