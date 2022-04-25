using M4;

Person arnis = new Person("Arnis");
arnis.Name = "Arnis";
arnis.Surname = "Ozolins";
arnis.BirthDate = 10.11.1980;
arnis.Gender = true;

string arnisName = arnis.Name;
Console.WriteLine($"I Have created with name  {arnisName} ");


phone1.Size = 15;
phone1.Brand = "nokia";
phone1.Model = "galaxy";

string phonename = phone1.Brand;

string phonemodel = phone1.Model;

Console.WriteLine($"apsveicu jauns telefons {phonename} modelis {phonemodel}");

phone1.Call();

phone1.Sms();
arnis.Greeting();
arnis.Call("22233222222");