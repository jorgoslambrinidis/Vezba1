using Vezba1;

#region Test Region 1 - Commented

//Console.WriteLine("Hello, World!!!");
// Console.ReadKey();

/* ova 
 * e
 * multiline
 * comment
  */

// ova e single line comment

//string a = "nekoja recenica";
//int b = 30;
//double c = 0.2;

//int a = 1;
//int b = 2;
//int c = 3;
//int d = a /* ova e objasnuvanje za promenliva a */ + c;
//int finalResult = 4;

//0  //1  //2 //3  //4
//Console.WriteLine($"Rezultatot na 1 + 3 = {finalResult}");


//Console.WriteLine(36 - 6);
//Console.WriteLine(36 / 6);
//Console.WriteLine(5 * 10);

//string text = Console.ReadLine();
//Console.WriteLine("Ova e tekstot koj sto e vnesen od strana na user: {0}", text);

//Console.WriteLine("Vnesete gi posledovaltelno 4te varijabli a, b, c, d");
//Console.WriteLine("******************************************************");
//Console.WriteLine("Vnesete go prviot broj: ");
//int a = int.Parse(Console.ReadLine());

//int imeNaPrvaPromenliva = 0;

//if (a == 1)
//{
//    Console.WriteLine("True");
//}
//else
//{
//    Console.WriteLine("False");
//}

//Console.WriteLine("Vnesete go vtoriot broj: ");
//int b = int.Parse(Console.ReadLine());

//if (b == 2)
//{
//    Console.WriteLine("True");
//}
//else
//{
//    Console.WriteLine("False");
//}

//Console.WriteLine("Vnesete go tretiot broj: ");
//int c = int.Parse(Console.ReadLine());

//if (c == 3)
//{
//    Console.WriteLine("True");
//}
//else
//{
//    Console.WriteLine("False");
//}

//Console.WriteLine("Vnesete go cetvrtiot broj: ");
//int d = int.Parse(Console.ReadLine());

//if (d == 4)
//{
//    Console.WriteLine("True");
//}
//else
//{
//    Console.WriteLine("False");
//}


//if (a == 1 && b == 2 && c == 3 && d == 4)
//{
//    int result = a + b + c + d;
//    Console.WriteLine(result);
//}
//else
//{
//    Console.WriteLine("Error");
//}



// nekoj comment
// nekoj comment 2

// nesto developirame novo vo noviot branch
// nesto developirame novo vo noviot branch 2
// nesto developirame novo vo noviot branch 3
// nesto developirame novo vo noviot branch 4
// nesto developirame novo vo noviot branch 5
// nesto developirame novo vo noviot branch 6_6
// nesto developirame novo vo noviot branch 6___
// nesto developirame novo vo noviot branch 7


//string space = "/";
// "1234"


#endregion


#region Test Region 2

Console.WriteLine("Region 2 Execute....");

//var functions = new Functions();
Functions functions = new Functions();

User user = new User();
user.Id = 1;
user.Name = "Ivan";
user.Country = "Macedonia";
user.City = "Skopje";
user.Address = "Ilindenska br.1";
user.Email = "korisnik@gmail.com";
user.Username = "username_korisnik";
user.Password = "password";
user.DateCreated = DateTime.Now;
user.LastOnline = DateTime.Now;
user.Years = 30;

User user2 = new User()
{
    Id = 2,
    Name = "Jovan",
    City = "Veles",
    Country = "Macedonia"
};

Console.WriteLine(user);
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");

Console.WriteLine(
    $"Kornisnikot so ime {user.Name}\n" +
    $"so mesto na ziveenje vo {user.City}, {user.Country} \n" +
    $"ima {user.Years} godini!"
    );

Console.WriteLine("\n");

Console.WriteLine(
    $"Kornisnikot so ime {user2.Name}\n" +
    $"so mesto na ziveenje vo {user2.City}, {user2.Country} \n" +
    $"ima {user2.Years} godini!"
    );

var number = 1;

//var checkIfNumber = 


#endregion