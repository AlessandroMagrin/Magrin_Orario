using System;

namespace Orario
{
    internal class COrario
    {
        private int _ore;
        private int _minuti;
        private int _secondi;

        public COrario()
        {
            _secondi = 0;
            _minuti = 0;
            _ore = 0;
        }

        public COrario(int ore, int min, int sec)
        {
            _ore = ore;
            _minuti = min;
            _secondi = sec;
            Normalizza(); 
        }

        public COrario(int secondiTotali)
        {
            //le ore hanno 3600 secondi
            _ore = secondiTotali / 3600;
            secondiTotali %= 3600;
            _minuti = secondiTotali / 60;
            _secondi = secondiTotali % 60;
            Normalizza();
        }

        public int ore
        {
            get { return _ore; }
            set
            {
                _ore = value;
                Normalizza();
            }
        }

        public int minuti
        {
            get { return _minuti; }
            set
            {
                _minuti = value;
                Normalizza();
            }
        }

        public int secondi
        {
            get { return _secondi; }
            set
            {
                _secondi = value;
                Normalizza();
            }
        }

        private void Normalizza()
        {
           
        {
            
            if (_secondi > 59)
            {
                _minuti += _secondi / 60; // Quanti secondi ci sono in più e li porta in minuti e il resto va in secondi
                _secondi = _secondi % 60; 
            }

           
            if (_minuti > 59)
            {
                _ore += _minuti / 60;
                _minuti = _minuti % 60;
            }


            if (_ore > 23)
            {
                _ore = _ore % 24;
            }
        }
        }

        public int ToSecondi()
        {
            // Calcola tutti i secondi totali
            return (_ore * 3600) + (_minuti * 60) + _secondi;
        }

        public override string ToString()
        {
            //D2=mette il numero a 2 cifre (es."5:2:24"="05:02:24")
            return _ore.ToString("D2") + ":" + _minuti.ToString("D2") + ":" + _secondi.ToString("D2");
        }

        public COrario Aggiungi(int secondi)
        {
            return new COrario(this.ore, this.minuti, this.secondi + secondi);
           
        }

        public COrario Aggiungi(int ore, int minuti, int secondi)
        {
            return new COrario(this.ore + ore, this.minuti + minuti, this.secondi + secondi);
          
        }
        public static COrario Confronta(COrario a, COrario b)
        {
            // Uso ToSecondi() per capire facilmente chi è più grande
            if (a.ToSecondi() > b.ToSecondi())
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public static COrario operator +(COrario o1, COrario o2)
        {
            //sommo tutto
            //ritornando un nuovo COrario non serve fare un Normalizza 
            //perchè chiamo il costruttore della classe che normalizza da solo
            return new COrario(o1.ore + o2.ore, o1.minuti + o2.minuti, o1.secondi + o2.secondi);
           
        }

        public static COrario operator -(COrario o1, COrario o2)
        {
            // Calcolo la differenza totale in secondi per evitare problemi di prestito
            int tot1 = o1.ore * 3600 + o1.minuti * 60 + o1.secondi;
            int tot2 = o2.ore * 3600 + o2.minuti * 60 + o2.secondi;

            if (tot1 < tot2)
                throw new ArgumentException("Il primo orario deve essere maggiore del secondo");
            else

            return new COrario(tot1 - tot2);
        }

        
        public static bool operator ==(COrario o1, COrario o2)
        {
            //se tutto è uguale ritorna true al contrario va nel false
            if (o1.ore == o2.ore && o1.minuti == o2.minuti && o1.secondi == o2.secondi)
            {
                return true;
            }
            else
                return false;
           
        }

        public static bool operator !=(COrario o1, COrario o2)
        {
            //se almeno uno è differente ritorna true al contrario ritorna false
            if (o1.ore != o2.ore || o1.minuti != o2.minuti || o1.secondi != o2.secondi)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator >(COrario o1, COrario o2)
        {
            //porto tutto in secondi per semplificare il codice
            return o1.ToSecondi() > o2.ToSecondi();
        }

        public static bool operator <(COrario o1, COrario o2)
        {
            //porto tutto in secondi per semplificare il codice
            return o1.ToSecondi() < o2.ToSecondi();
       }




        static void Main(string[] args)
        {
            COrario tempo1= new COrario(2,71,82);
            COrario tempo2 =new COrario(13, 43, 12);
            Console.WriteLine("Tempo 1:\t\n" + tempo1.ToString());
            Console.WriteLine("Tempo 2:\t\n" + tempo2.ToString());

            Console.WriteLine("Somma:\t\n" +(tempo1+tempo2).ToString());
            Console.WriteLine("Sottrazione:\t\n"+ (tempo1 - tempo2).ToString());
            //?
            Console.WriteLine("Moltiplicazione:\t\n" + (tempo1 * 3).ToString());
            Console.WriteLine("Uguali:\t\n+" + (tempo1 == tempo2));
            Console.WriteLine("Maggiori:\t\n+" + (tempo1 > tempo2));
            Console.WriteLine("AggiungiSecondi(50):\t\n"+tempo1.Aggiungi(50).ToString());
            Console.WriteLine("AggiungiTempoTotale(1,5,3):\t\n" + tempo1.Aggiungi(1,5,3).ToString());
            Console.WriteLine("Confronto:\t\n" + COrario.Confronta(tempo1,tempo2).ToString());
            tempo1.minuti = 70;
            Console.WriteLine("Aggiunto 70 minuti:\t\n" + tempo1.ToString());

        }
    } 
} 
