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

        public void AddNew(String name)
        {
            Artist a = new Artist();
            a.Title = name;
            _context.Artists.Add(a);
            _context.SaveChanges();
        }


    }
}
