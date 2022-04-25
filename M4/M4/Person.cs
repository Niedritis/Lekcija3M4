namespace M4
{
    public class Person
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Hobby { get; set; }
        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
      

        public void Greeting()
        { 
         Console.WriteLine($"Hello  my name is {Name} {Surname}.");
        
         Console.WriteLine($"I am {GetAge()} and my hobby is {Hobby}.");
        }







    }

}






