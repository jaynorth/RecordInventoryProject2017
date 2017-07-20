using RecordsDataModel.EntityModels;
using System;
using System.Collections.Generic;
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

            _listArtists = new List<Artist>(_context.Artists
                .OrderBy(a =>a.Title));

        }

        private List<Artist> _listArtists;

        public List<Artist> ListArtists
        {
            get { return _listArtists; }
            set { _listArtists = value; }
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
            _context.SaveChanges();
        }


    }
}
