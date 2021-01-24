using System;
using System.Collections.Generic;


namespace Kolokwium2
{
    public class Program
    {
        static void Main()
        {
            Console.Read();
        }
    }
    public abstract class Usluga
    {
        public Usluga(DateTime x)
        {
            this.czas = x;
        }
        protected DateTime czas;
        protected double cena;

        public abstract void ObliczCene();
    }

    public class Polaczenie : Usluga
    {
        private string numer;
        private int czasP;

        public Polaczenie(DateTime t) : base(t) => this.czas = t;

        public override void ObliczCene() => this.cena = czasP * 0.28;
        public Polaczenie(DateTime t, string n, int p) : base(t)
        {
            this.czas = t;
            this.numer = n;
            this.czasP = p;
            ObliczCene();
        }

        public override string ToString()
        {
            return "Połączenie: numer " + this.numer + " , data i godzina rozmowy:" + this.czas + " , długość trwania: " + this.czasP + " , łączny koszt:" + this.cena;
        }
    }
    public class Sms : Usluga
    {
        private string numer;

        public override void ObliczCene() => this.cena = 0.14;

        public Sms(DateTime t, string n) : base(t)
        {
            this.czas = t;
            this.numer = n;
            ObliczCene();
        }

        public override string ToString()
        {
            return this.czas + " numer : " + this.numer + "cena : " + this.cena + "";
        }
    }

    public class Internet : Usluga
    {
        private int iloscMb;

        public override void ObliczCene()
        {
            this.cena = Math.Round(iloscMb / 756.0, 2);
        }
        public Internet(DateTime t, int d) : base(t)
        {
            this.czas = t;
            this.iloscMb = d;
            ObliczCene();
        }
        public override string ToString()
        {
            return this.czas + " " + this.iloscMb + " " + this.cena;
        }

    }

}