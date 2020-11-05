using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YannisAnnoula.Models
{
    class BuildingBlock
    {
        private string _door;
        private string _window;
        private string _wall;
        private string _mandalos;

        public string Door
        {
            get { return _door; }
            protected private set { _door = value; }
        }
        public string Window
        {
            get { return _window; }
            protected private set { _window = value; }
        }
        public string Wall
        {
            get { return _wall; }
            protected private set { _wall = value; }
        }

        public string Mandalos
        {
            get { return _mandalos; }
            protected private set { _mandalos = value; }
        }

        public BuildingBlock()
        {

        }
        public BuildingBlock(string door, string mandalos)
        {


        }



    }
}
