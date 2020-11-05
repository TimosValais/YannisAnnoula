using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YannisAnnoula.Business_Logic
{
    interface IHumanActions
    {
        void MoveHand(string nameOfPerson);
        void Walk(string nameOfPerson);

        void Talk(string nameOfPerson, string speach);
    }
}
