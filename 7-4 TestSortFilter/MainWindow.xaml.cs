using System;
using System.Windows;
using System.Windows.Data;

namespace _10_TestSortFilter
{
    public partial class MainWindow : Window
    {
        // Collection de données
        private FamilyMembers _listPersonnes = new FamilyMembers();
        public FamilyMembers ListPersonnes
        {
            get { return _listPersonnes; }
            set { _listPersonnes = value; }
        }

        // Filtre
        private string _filtre;

        public string Filtre
        {
            get { return _filtre; }
            set {  _filtre = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            filtrecontext.DataContext = this;
            Filtre = "Simpson";
            
            ListPersonnes.Add(new Personne("Simpson", "Homer", new DateTime(2051, 5, 21),
                @"Images\HomerSimpson.png"));
            ListPersonnes.Add(new Personne("Simpson", "Marge", new DateTime(2050, 5, 30),
                @"Images\MargeSimpson.png"));
            ListPersonnes.Add(new Personne("Simpson", "Maggie", new DateTime(2018, 5, 15)));
            ListPersonnes.Add(new Personne("Simpson", "Bart", new DateTime(2018, 5, 30)));
            ListPersonnes.Add(new Personne("Sparrow", "Jack", new DateTime(1985, 4, 21), @"Images\JackSparrow.png"));

            dgBase.ItemsSource = ListPersonnes;
            System.Diagnostics.PresentationTraceSources.DataBindingSource.Switch.Level = System.Diagnostics.SourceLevels.Critical;
        }

        private void Contains(object sender, FilterEventArgs e)
        {
            Personne item = e.Item as Personne;
            if (item != null)
            {
                if (item.Nom.Contains(Filtre))
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(dgFamille.ItemsSource).Refresh();
        }
    }
}
