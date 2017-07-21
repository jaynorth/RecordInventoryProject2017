using RecordsDataModel.EntityModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }


        private ObservableCollection<Artist> _listArtists;

        public ObservableCollection<Artist> ListArtists
        {
            get { return _listArtists; }
            set
            {
                _listArtists = value;
               // OnPropertyChanged();
            }
        }

        public void Add(String name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("name should not be empty", "name");
            }

            //process string
            name = name.Trim();

            bool existInList = false;

            foreach (var artist in ListArtists)
            {
                if (artist.Title.ToUpper() == name.ToUpper())
                {
                    existInList = true;
                    break;
                }
            }

            if (existInList)
            {
                throw new ArgumentException("name already is in the list", "name");
            }

            Artist a = new Artist();
            a.Title = name;

            _context.Artists.Add(a);
            _listArtists.Add(a);
            _context.SaveChanges();
           // Init();
        }


    }
}
