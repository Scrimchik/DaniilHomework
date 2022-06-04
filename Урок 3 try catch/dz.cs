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
                    throw new HeroPickException("������ ������� = ��� ������, �� �� ��� ������ ��������� � ������� ������� �����", value);
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

        }
    }
}