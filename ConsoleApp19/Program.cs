using System;
using ConsoleApp19.Models;
namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon w = new Weapon(10, 4, 4, true);

            int choose = 0;
            while (choose != 6)
            {
                Console.WriteLine("choose");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        {
                            w.Shoot();
                        }
                        break;
                    case 1:
                        {
                            w.Fire();
                        }
                        break;
                    case 2:
                        {
                            w.GetRemainBulletCount();
                        }
                        break;
                    case 3:
                        {
                            w.Reload();
                        }
                        break;
                    case 4:
                        {
                            w.GetInfo();
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("sefdir");
                        }
                        break;
                }

                }
            }
        }
}
