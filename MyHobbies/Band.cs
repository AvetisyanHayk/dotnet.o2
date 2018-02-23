using System;
using System.Collections.Generic;
using System.Text;

namespace MyHobbies
{
    public class Band
    {
        public int Jaar { get; set; }
        public string Naam { get; set; }

        public List<BandLid> BandLeden { get; set; }

        public Band()
        {
            this.BandLeden = new List<BandLid>();
        }

        public override string ToString()
        {
            return $"Band: {Naam}, Jaar: {Jaar}";
        }
    }
}
