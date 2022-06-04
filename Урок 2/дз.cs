namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Hero hero = new Hero(Dota2Hero.Tinker);
            }
            catch (HeroPickException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Потому что вы выбрали {ex.Hero}");
            }
        }
    }

    class Hero
    {
        public Dota2Hero PickedHero
        {
            set
            {
                if (value == Dota2Hero.Tinker)
                    throw new HeroPickException("Пикнул тинкера = Плохой Человек, но ты еще можешь одуматься и выбрать другого героя", value);
                else
                    PickedHero = value;
            }
        }

        public Hero(Dota2Hero pickedHero)
        {
            PickedHero = pickedHero;
        }
    }

    enum Dota2Hero
    {
        Tinker,
        Lion,
        Invoker,
        Io
    }

    class HeroPickException : Exception
    {
        public HeroPickException(string message, Dota2Hero value) : base(message)
        {
            Hero = value;
        }

        public Dota2Hero Hero { get; set; }
    }
}