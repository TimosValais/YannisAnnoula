using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YannisAnnoula.Business_Logic
{
    interface IInteractionWithObject
    {
        void OpensDoor(string personOpening);
        void ClosesDoor(string personClosing);
    }
}
