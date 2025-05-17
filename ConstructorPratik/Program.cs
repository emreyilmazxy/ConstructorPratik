namespace Yapicimethod
{
    class Baby
    {
        public string _name;
        public string _surname;
        public string _birtDay; 
        public Baby(string name, string surName)
        {
            _name = name;
            _surname = surName;
            _birtDay = DateTime.Today.ToShortDateString();
            Console.WriteLine($"ıngaaaaa {_birtDay} bebek adı:{_name} soy adı:{_surname}  ");
        }

        public Baby()
        {
           
            _birtDay = DateTime.Today.ToShortDateString();
            Console.WriteLine($"ıngaaaaa {_birtDay} ");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Baby baby = new Baby("Ali", "yılmaz");
            Baby baby2 = new Baby();
            baby2._name = "Mehmet";
            baby2._surname = "şeker";
            Console.WriteLine($"bebek adı:{baby2._name} soy adı:{baby2._surname}  ");
        }
    }
}