using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            WaterGun waterGun = new WaterGun();

            player.Fire(waterGun);
            
        }

        class Player
        {
            public void Fire(Weapon weapon)
            {
                weapon.Fire();
            }
        }

        abstract class Weapon
        {
            public abstract void Fire();

            
        }

        class LaserGun : Weapon
        {
            public override void Fire()
            {
                Console.WriteLine("Выстрел с Ракетницы");
            }
        }

        class PistolGun : Weapon
        {
            public override void Fire()
            {
                Console.WriteLine("Выстрел с  Пистолета");
            }
        }

        class WaterGun : Weapon
        {
            public override void Fire()
            {
                Console.WriteLine("Выстрел с ВодногоПистолета");
            }
        }
    }
}
