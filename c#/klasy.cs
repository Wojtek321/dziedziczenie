using System.Net.Mail;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

namespace program
{
    class Figura
    {
        protected string kolor;

        public Figura(string kolor)
        {
            this.kolor = kolor;
        }

        public string getKolor()
        {
            return this.kolor;
        }

        public void setKolor(string kolor)
        {
            this.kolor = kolor;
        }
    }

    class Trojkat : Figura
    {
        protected Linia l1;
        protected Linia l2;
        protected Linia l3;
        
        public Trojkat(string kolor, Punkt p1, Punkt p2, Punkt p3) : base(kolor)
        {
            this.l1 = new Linia(p1, p2);
            this.l2 = new Linia(p2, p3);
            this.l3 = new Linia(p3, p1);
        }

        public override string ToString()
        {
            return $"{this.kolor} trojkat: {this.l1} {this.l2} {this.l3}";
        }
    }

    class Czworokat : Figura
    {
        protected Linia l1;
        protected Linia l2;
        protected Linia l3;
        protected Linia l4;

        public Czworokat(string kolor, Punkt p1, Punkt p2, Punkt p3, Punkt p4) : base(kolor)
        {
            this.l1 = new Linia(p1, p2);
            this.l2 = new Linia(p2, p3);
            this.l3 = new Linia(p3, p4);
            this.l4 = new Linia(p4, p1);
        }

        public override string ToString()
        {
            return $"{this.kolor} czworokat: {this.l1} {this.l2} {this.l3} {this.l4}";
        }
    }

    class Prostokat : Czworokat
    {
        public Prostokat(string kolor, Punkt p1, Punkt p2) : base(kolor, p1, new Punkt(p2.x, p1.y), p2, new Punkt(p1.x, p2.y))
        {
            
        }

        public override string ToString()
        {
            return $"{this.kolor} prostokat: {this.l1} {this.l2} {this.l3} {this.l4}";
        }
    }

    class Kwadrat : Prostokat
    {
        public Kwadrat(string kolor, Punkt p1, int bok) : base(kolor, p1, new Punkt(p1.x+bok, p1.y+bok))
        {
            
        }

        public override string ToString()
        {
            return $"{this.kolor} kwadrat: {this.l1} {this.l2} {this.l3} {this.l4}";
        }
    }

    public class Punkt
    {
        public int x;
        public int y;

        public Punkt()
        {
            this.x = 0;
            this.y = 0;
        }
    
        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    
        public Punkt(Punkt punkt)
        {
            this.x = punkt.x;
            this.y = punkt.y;
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }

    public class Linia
    {
        private Punkt p1;
        private Punkt p2;

        public Linia()
        {
            this.p1 = new Punkt();
            this.p2 = new Punkt();
        }
        
        public Linia(Punkt p1, Punkt p2)
        {
            this.p1 = new Punkt(p1);
            this.p2 = new Punkt(p2);
        }
        
        public Linia(Linia linia)
        {
            this.p1 = new Punkt(linia.p1);
            this.p2 = new Punkt(linia.p2);
        }

        public override string ToString()
        {
            return $"[{p1}, {p2}]";
        }
    }
}