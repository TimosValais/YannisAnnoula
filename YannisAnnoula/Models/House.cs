using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YannisAnnoula.Models
{
    class House : BuildingBlock
    {
        public House()
        {
            this.Door = "generic Door";
            this.Mandalos = "generic Mandalos";
            this.Wall = "generic Wall";
            this.Window = "generic Window";
        }
        public House(string door, string mandalos)
        {
            door = this.Door;
            mandalos = this.Mandalos;
        }
    }
}
