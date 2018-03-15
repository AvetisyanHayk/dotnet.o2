using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MyHobbies
{
    public class Band
    {
        public const int MIN_JAAR = 1900;
        public int Jaar { get; set; }
        public string Naam { get; set; }
        public List<BandLid> BandLeden { get; set; }
        public Band()
        {
            this.BandLeden = new List<BandLid>();
            this.Jaar = MIN_JAAR;
        }
        public static int MaxJaar()
        {
            return DateTime.Now.Year;
        }
        public void AddLid(BandLid lid)
        {
            this.BandLeden.Add(lid);
        }
        public override string ToString()
        {
            return $"Band: {Naam}, Jaar: {Jaar}";
        }
    }
}
