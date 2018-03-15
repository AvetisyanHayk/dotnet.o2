using MyHobbies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.o2.Models
{
    public class BandModel
    {
        private static List<Band> Bands = new List<Band>();

        static BandModel()
        {
            Band band1 = new Band
            {
                Jaar = 1995,
                Naam = "System of a Down",
                BandLeden = new List<BandLid>
                {
                    new BandLid { Naam="Serj Tankian", Geslacht=Geslacht.Man, Leeftijd=50, IsAlive=true},
                    new BandLid { Naam="Daron Malakian", Geslacht=Geslacht.Man, Leeftijd=42, IsAlive=true},
                    new BandLid { Naam="Shavo Odadjian", Geslacht=Geslacht.Man, Leeftijd=43, IsAlive=true},
                    new BandLid { Naam="John Dolmayan", Geslacht=Geslacht.Man, Leeftijd=44, IsAlive=true}
                }
            };
            Band band2 = new Band
            {
                Jaar = 1972,
                Naam = "ABBA",
                BandLeden = new List<BandLid>
                {
                    new BandLid { Naam="Agnetha Fältskog", Geslacht=Geslacht.Vrouw, Leeftijd=67, IsAlive=true},
                    new BandLid { Naam="Daron Malakian", Geslacht=Geslacht.Man, Leeftijd=72, IsAlive=true},
                    new BandLid { Naam="Shavo Odadjian", Geslacht=Geslacht.Man, Leeftijd=71, IsAlive=true},
                    new BandLid { Naam="John Dolmayan", Geslacht=Geslacht.Man, Leeftijd=72, IsAlive=true}
                }
            };
            Bands.Add(band1);
            Bands.Add(band2);
        }
        public List<Band> GetAll() => Bands;
        public Band GetByName(string naam)
        {
            foreach (Band band in GetAll())
            {
                if (band.Naam == naam) return band;
            }
            return null;
        }
        public void AddBandLid(BandLid lid, string bandnaam)
        {
            Band band = GetByName(bandnaam);
            band.AddLid(lid);
        }
        public void AddBand(string naam, int jaar)
        {
            Band band = GetByName(naam);
            if (band != null)
            {
                band.Jaar = jaar;
                SaveBand(band);
            }
            else
            {
                band = new Band { Jaar = jaar, Naam = naam };
                AddBand(band);
            }
            
        }
        public void AddBand(Band band)
        {
            Bands.Add(band);
        }
        public void SaveBand(Band band)
        {
            Band _band = GetByName(band.Naam);
            if (_band != null)
            {
                Bands.Remove(_band);
            }
            AddBand(band);
        }
        
    }
}
