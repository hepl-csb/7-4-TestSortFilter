using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _10_TestSortFilter
{
    public class Personne : INotifyPropertyChanged
    {
        #region var membre et propriétés

        private string _nom;
        public string Nom
        {
            get { return _nom; }
            set
            {
                if (_nom != value)
                {
                    _nom = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _prenom;
        public string Prenom
        {
            get { return _prenom; }
            set { 
                if (_prenom != value)
                { 
                    _prenom = value;
                    NotifyPropertyChanged();
                }
                }
        }
        
        private string _imagepath;
        public string ImagePath
        {
            get { return _imagepath; }
            set
            {
                if (_imagepath != value)
                {
                    _imagepath = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private DateTime _datenaissance;
        public DateTime DateNaissance
        {
            get { return _datenaissance; }
            set
            {
                if (_datenaissance != value)
                {
                    _datenaissance = value;
                    NotifyPropertyChanged();
                }
            }
        }
        #endregion
        public Personne() :this("","",DateTime.Now)
        { }
        public Personne(string nom, string prenom, DateTime naissance, string imagePath="")
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = naissance;
            if (imagePath == null || imagePath == "")
                ImagePath = @"Images\Default.png";
            else
                ImagePath = imagePath;
        }
        public Personne(Personne p)
        {
            Nom = p.Nom;
            Prenom = p.Prenom;
            DateNaissance = p.DateNaissance;
            ImagePath = p.ImagePath;
        }

        public override string ToString()
        {
            return Nom + " " + Prenom + " " + DateNaissance.ToString("dd MM yyyy");
        }

        public bool IsValid()
        {
            if (Nom.Length > 0 && Prenom.Length > 0)
                return true;
            else
                return false;
        }
        private void NotifyPropertyChanged([CallerMemberName] string propertyname=null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
