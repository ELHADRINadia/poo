using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_test
{
    internal class ren:car
    {
        private string nom;
        public ren() { }
        public ren(string n)
        {
            this.nom = n;
        }
        public string getnom()
        {
            return this.nom;
        }
        public void setnom(string n)
        {
            this.nom = n;
        }
        public string AfficherInfos()
        {
            return "les info est "+ this.nom + " "+ this.Model + " " + this.Matricule + "  " + this.Couleur; 
        }
    }
}


