using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progettoCD
{
    internal class CD
    {
                                string titolo;
        string autore;
        List<Brano> lista = new List<Brano>();

        public CD(string titolo, string autore, Brano lista)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.lista = lista;
        }
        public string getTitolo()
        {
            return titolo;
        }
        public string getAutore()
        {
            return autore;
        }
        public void setTitolo(string titolo)
        {
            this.titolo=titolo;
        }
        public void setAutore(string autore)
        {
            this.autore = autore;
        }
        public string toString()
        {
            string titoli = " ";
            for(int i=0; i<lista.Count(); i++)
            {
                titoli= titoli + lista[i].toString();
            }
            return titoli;
        }
        public string Durata()
        {
            string durataTotale = " ";
            int i = 0;
            foreach(Brano b in lista)
            {
                durataTotale = durataTotale + lista[i].getDurata();
                i++;
            }
            return durataTotale;
        }
    }
}
