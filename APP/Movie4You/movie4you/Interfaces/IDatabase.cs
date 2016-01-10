using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie4You.Interfaces
{
    interface IDatabase
    {
        void Connect();
        void Disconnect();
        void Select();
        void Delete();
        void Update();
        void Insert();
        void Sanitize();

    }
}
