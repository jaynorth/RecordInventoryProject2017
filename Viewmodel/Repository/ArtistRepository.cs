using RecordsDataModel.EntityModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viewmodel.ViewModel.Helpers;

namespace Viewmodel.Repository 
{
    public class ArtistRepository : BaseViewModel
    {
 

        public  void Add(string artistName, ObservableCollection<Artist> ListArtists)
        {

            bool existInList = false;

            foreach (var artist in ListArtists)
            {
                if (artist.Title.ToUpper() == artistName.ToUpper())
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
            a.Title = artistName;

            

            ListArtists.Add(a);

            _context.Artists.Add(a);
            _context.SaveChanges();
        }

    }
}
