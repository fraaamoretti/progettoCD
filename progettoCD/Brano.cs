using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progettoCD
{
    internal class Brano
    {
        private string titolo;
        private string autore;
        private string durata;

        public Brano(string titolo, string autore, string durata)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.durata = durata;
        }

        public string getTitolo()
        {
            return titolo;
        }

        public string getAutore()
        {
            return autore;
        }

        public string getDurata()
        {
            return durata;
        }

        public void setTitolo(string titolo) 
        { 
            this.titolo = titolo;
        }

        public void setAutore(string autore)
        {
            this.autore = autore;
        }

        public void setDurata(string durata)
        {
            this.durata=durata;
        }

        public string toString()
        {
            return $"Titolo: {titolo}\n Autore: {autore}\n Durata: {durata}";
        }

        public bool shortSong(double durataIn)
        {
            if(double.Parse(durata) < durataIn)
            {
                return true;
            }else return false;
        }
    }
}
