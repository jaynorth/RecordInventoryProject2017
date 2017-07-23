using GalaSoft.MvvmLight.CommandWpf;
using RecordsDataModel.EntityModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viewmodel.Repository;
using Viewmodel.ViewModel.Helpers;

namespace Viewmodel.ViewModel
{
    public class NewRecordViewModel : BaseViewModel
    {

        public NewRecordViewModel()
        {
            Init();

        }

        private void Init()
        {
            _listArtists = new ObservableCollection<Artist>(_context.Artists
                .OrderBy(a => a.Title));
            AddNewArtist = new RelayCommand<string>((s) => AddArtist(s));
            _listGenres = new ObservableCollection<Genre>(_context.Genres
                .OrderBy(g => g.Name));
            AddNewGenre = new RelayCommand<string>((s) => AddGenre(s));

            _listLabels = new ObservableCollection<Label>(_context.Labels
               .OrderBy(g => g.Name));
            AddNewLabel = new RelayCommand<string>((s) => AddLabel(s));

            _listCountries = new ObservableCollection<Country>(_context.Countries
               .OrderBy(g => g.Name));
            AddNewCountry = new RelayCommand<string>((s) => AddCountry(s));

            MonthsArray = new string[] { "Unknown", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "december" };

            _listRecords = new ObservableCollection<Mrecord>(_context.Mrecords);
            _currentRecord = new Mrecord();
            _currentRecord.ID = -1;

            AddNewRecord = new RelayCommand(AddRecord);

        }

        public RelayCommand<string> AddNewArtist { get; set; }
        public RelayCommand<string> AddNewGenre { get; set; }

        public RelayCommand<string> AddNewLabel { get; set; }
        public RelayCommand<string> AddNewCountry { get; set; }

        public RelayCommand AddNewRecord { get; set; }

        public void Test(String text)
        {
            Console.WriteLine("this is a test in console: " + text);
        }

        private Mrecord _currentRecord;

        public Mrecord CurrentRecord
        {
            get { return _currentRecord; }
            set
            {
                _currentRecord = value;

                OnPropertyChanged();
            }
        }


        private ObservableCollection<Genre> _listGenres;

        public ObservableCollection<Genre> ListGenres
        {
            get { return _listGenres; }
            set
            {
                _listGenres = value;
                OnPropertyChanged();

            }
        }

        private ObservableCollection<Country> _listCountries;

        public ObservableCollection<Country> ListCountries
        {
            get { return _listCountries; }
            set
            {
                _listCountries = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Mrecord> _listRecords;

        public ObservableCollection<Mrecord> ListRecords
        {
            get { return _listRecords; }
            set
            {
                _listRecords = value;
                OnPropertyChanged();
            }
        }


        private ObservableCollection<Artist> _listArtists;

        public ObservableCollection<Artist> ListArtists
        {
            get { return _listArtists; }
            set
            {
                _listArtists = value;
                OnPropertyChanged();

            }
        }

        private ObservableCollection<Label> _listLabels;

        public ObservableCollection<Label> ListLabels
        {
            get { return _listLabels; }
            set
            {
                _listLabels = value;
                OnPropertyChanged();
            }
        }


        public void AddArtist(String artistName)
        {
            ProcessStringInput(artistName);

            ArtistRepository ar = new ArtistRepository();

            ar.Add(artistName, ListArtists);

        }

        public void AddLabel(String labelName)
        {
            ProcessStringInput(labelName);

            LabelRepository lr = new LabelRepository();

            lr.Add(labelName, ListLabels);

        }

        public void AddCountry(String countryName)
        {
            ProcessStringInput(countryName);

            CountryRepository cr = new CountryRepository();

            cr.Add(countryName, ListCountries);

        }

        public void AddRecord()
        {
            MrecordRepository mrec = new MrecordRepository();
            mrec.Add(CurrentRecord);
        }

        private void ProcessStringInput(String s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                throw new ArgumentException("name should not be empty", "name");
            }

            s = s.Trim();
        }

        public void AddGenre(String genreName)
        {

            ProcessStringInput(genreName);

            GenreRepository gr = new GenreRepository();

            gr.Add(genreName, ListGenres);

        }

        public string[] MonthsArray { get; set; }


    }
}
