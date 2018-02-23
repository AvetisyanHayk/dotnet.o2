using System;
using System.Collections.Generic;
using System.Text;

namespace MyHobbies
{
    public enum Geslacht
    {
        Man,
        Vrouw
    }
    public class BandLid
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Geslacht Geslacht { get; set; }
        public bool isAlive { get; set; }

        public BandLid()
        {
            this.isAlive = true;
        }

        public override string ToString()
        {
            return $"Naam: {Naam}, Leeftijd: {Leeftijd}, Geslacht: {Geslacht}, is alive: {isAlive}";
        }
    }
}
