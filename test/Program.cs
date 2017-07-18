using RecordsDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            RecordsDBEntities context = new RecordsDBEntities();

            List<Artist> ListArtist = new List<Artist>(context.Artists);

            var ArtistName = ListArtist.FirstOrDefault().Title.ToString();
            Console.WriteLine(ArtistName);

            List<Mrecord> ListRecords = new List<Mrecord>(context.Mrecords);

            foreach (var item in ListRecords)
            {
                Console.WriteLine(item.Title);
            }


        }
    }
}
