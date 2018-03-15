using System;
using System.Collections.Generic;
using System.Text;

namespace MyHobbies
{
    public enum Geslacht
    {
        Undefined,
        Man,
        Vrouw
    }
    public class BandLid
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Geslacht Geslacht { get; set; }
        public bool IsAlive { get; set; }

        public BandLid()
        {
            this.IsAlive = true;
        }

        public override string ToString()
        {
            return $"Naam: {Naam}, Leeftijd: {Leeftijd}, Geslacht: {Geslacht}, is alive: {IsAlive}";
        }
    }
}
