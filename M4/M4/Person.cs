namespace M4
{
    public class Person
    {
        private string v;

        public Person(string v)
        {
            this.v = v;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Hobby { get; set; }
        public bool Gender { get; set; }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
    }


}

