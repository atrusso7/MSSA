using System;
using System.Collections.Generic;

namespace _25Mar_indexer
{
    class StarWars
    {
        private List<Characters> SWCharacters = new List<Characters>();
        public StarWars()
        {
            SWCharacters.Add(new Characters("Mace Windu", "Light"));
        }

    }
    class Characters
    {
        private string _side;
        private string _name;
        public string this[int i]
        {
            get => _side;
            set => _side = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public Characters(string name, string side)
        {
            this._name = name;
            this._side= side;
        }
    }
    class Sports
    {
        private string[] _sportName = {"Basketball", "Football", "Baseball", "Hockey"};
        public string this[int i]
        {
            get => _sportName[i];
            set => _sportName[i] = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new StarWars();
        }
    }
}
