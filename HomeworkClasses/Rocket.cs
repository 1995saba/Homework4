using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    public partial class Rocket
    {
        private int id;
        private string model;
        private bool inSpace;
        private double speed;
        private double startingSpeed;
        private DateTime dateOfStart;
        private static DateTime dateOfFirstStart;
        private static int numberOfRockets=0;

        static Rocket()
        {
            dateOfFirstStart = DateTime.Now;
        }

        public Rocket()
        {
            id = 123;
            model = "Sputnik";
            inSpace = false;
            speed = 0;
            startingSpeed = 1600;
            numberOfRockets++;
        }

        public Rocket(int id, string model, bool inSpace, double speed, double startingSpeed)
        {
            this.id = id;
            this.model = model;
            this.inSpace = inSpace;
            this.speed = speed;
            this.startingSpeed = startingSpeed;
            numberOfRockets++;
        }

        public Rocket(string model)
        {
            id = 123;
            this.model = model;
            inSpace = false;
            speed = 0;
            startingSpeed = 1600;
            numberOfRockets++;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public bool InSpace
        {
            get
            {
                return inSpace;
            }
            set
            {
                inSpace = value;
            }
        }

        public double Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public void Start()
        {
            if (inSpace = false && speed==0)
            {
                speed = startingSpeed;
                dateOfStart = DateTime.Now;
                Console.WriteLine("Ракета запущена. Удачного полета!");
            }
            else
            {
                Console.WriteLine("Ракета уже движется со скоростью {0} м/с", speed);
            }
        }

        public void Stop()
        {
            if (speed == 0)
            {
                Console.WriteLine("Ошибка. Ракета уже остановлена");
            }
            else
            {
                speed = 0;
                Console.WriteLine("Скорость максимально снижена. Остановка будет произведена в ближайшее время.");
            }
        }

        public double IncreaseSpeed()
        {
            return (speed * 2);
        }

        public double ReduceSpeed()
        {
            return (speed / 2);
        }
    }
}
