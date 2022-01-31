using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_test
{
     class car
    {
        //Attributs
        protected string Model;
        protected string Matricule;
        protected string Couleur;
        //constructeurs
        //constructeur par defaut
        public car() { }
        //constructeur initiatisant
        public car( string M, string Ma, string C) {
            this.Model = M;
            this.Matricule = Ma;
            this.Couleur = C;
        }
        //constructeur de recopie
        //Getter
        public string getModel()
        {
            return this.Model;
        }
        public string getMatricule()
        {
            return this.Matricule;
        }
        public string getCouleur()
        {
            return this.Couleur;
        }
        //Proprietés


        //Setters
        public void setModel(string M)
        {
             this.Model= M;
        }
        public void setMatricule(string Ma)
        {
            this.Matricule=Ma;
        }
        public void setCouleur(string C)
        {
           this.Couleur=C;
        }
        //autres Méthodes
        public string AfficherInfos()
        {
            return "les info est " + this.Model + " " + this.Matricule + "  " + this.Couleur;
            //Console.WriteLine("les infos sont");
            //Console.WriteLine("Model:" + this.Model, "\nMatricule:" + this.Matricule, "\nCouleur:" + this.Couleur);
        }
    }
}
