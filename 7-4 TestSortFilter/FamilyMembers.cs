using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_TestSortFilter
{
    public class FamilyMembers : ObservableCollection<Personne>
    {
        public FamilyMembers()
        {

        }

        public void Save(string filename)
        {
            // Save Members of the family
            // mettre ici le code qui permettrait d'enregistrer toutes les données de la collection
        }
    }
}
