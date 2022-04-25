using M4;

Person person1 = new Person();

Console.WriteLine("Lūdzu, ievadi savu vārdu");
string PeopleName = Console.ReadLine();

person1.Name = PeopleName;

Console.WriteLine("Lūdzu, ievadi savu uzvārdu");
string PeopleLastName = Console.ReadLine();
person1.Surname = PeopleLastName;


Console.WriteLine("Lūdzu, ievadi savu dz.dat dd,mm,yyyy");
string PeopleBirhtDay = Console.ReadLine();
person1.BirthDate = DateTime.Parse(PeopleBirhtDay);


Console.WriteLine("Lūdzu, ievadi savu hobiju");
string PeopleHobby = Console.ReadLine();
person1.Hobby = PeopleHobby;


person1.Greeting();

