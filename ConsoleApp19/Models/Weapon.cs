using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19.Models
{
    class Weapon
    {
        private int _bulletCap;
        private int _bulletCount;
        private double _time;
        private bool _auto = true;
        public int bulletcap
        {
            get
            {
                return _bulletCap;
            }
            set
            {
                if (value < 0 || value < bulletcount)
                {

                    value = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("daxil edilen inputsefdir");
                }
                _bulletCap = value;
            }
        }
        public int bulletcount
        {
            get
            {
                return _bulletCount;
            }
            set
            {
                if (value<0 || value>bulletcap)
                {
                    value = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("daxil edilen input sefdir");
                }
                _bulletCount = value;
            }
            
        }
        public double time
        {
            get
            {
                return _bulletCount;
            }
            set
            {
                if (value<=0)
                {
                    value = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("daxil edilen input sefdir");
                }
                _time = value;
            }
        }
        public bool auto
        {
            get
            {
                return _auto;
            }
            set
            {
                if (value == true)
                {
                    value = true;
                }
                else
                {
                    value = false;
                }
                _auto = value;
            }
            
             
        }
        public Weapon()
        {

        }


        public Weapon(int bulletCap, int bulletCount, double time, bool auto)
        {
            this._bulletCap = bulletCap;
            this._bulletCount = bulletCount;
            this._time = time;
            this._auto = auto;
            if (bulletCount > bulletCap)
            {
                Console.WriteLine("Xeberdarliq:gulle sayi tutumdan cox ola bilmez");
            }

        }
        public void GetInfo()
        {
            Console.WriteLine($"gulle tutumu:{ _bulletCap}");
            Console.WriteLine($"gulle sayi:{ _bulletCount}");
            Console.WriteLine($"vaxti:{ _time}");
        }
        public void Shoot()
        {


            if (_bulletCount <= 0)
            {
                Console.WriteLine("Gulle yoxdur");
            }
            else if (_auto == true)
            {

                _bulletCount--;

                if (_bulletCount > 0)
                {
                    _bulletCount--;

                }
                else
                {
                    Console.WriteLine("Gulle yoxdur");
                }

            }
        }

        public void Fire()
        {
            double shootbullets = 0;
            if (_bulletCount == 0)
            {
                Console.WriteLine("gulle  yoxdur");
                return;
            }
            if (_auto)
            {
                while (_bulletCount > 0)
                {
                    _bulletCount--;
                    shootbullets++;
                    Console.WriteLine(shootbullets);
                }
            }
            else
            {
                while (_bulletCount > 0)
                {
                    _bulletCount--;
                    shootbullets++;
                    Console.WriteLine(shootbullets);
                }
            }
            shootbullets *= (_bulletCap / time);
            Console.WriteLine($"gulle bu qeder vaxta atildi:{shootbullets}");
        }
        public void GetRemainBulletCount()
        {
            Console.WriteLine(_bulletCap - _bulletCount);
        }
        public void Reload()
        {
            if (_bulletCap - _bulletCount == 0)
            {
                Console.WriteLine("doludur");
            }
            else
            {
                Console.WriteLine(_bulletCap - _bulletCount);
                _bulletCount = _bulletCap;
            }
        }
    }
}
