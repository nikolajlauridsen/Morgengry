using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    interface IPersistable
    {
        void Save();
        void Save(string filename);
        void Load();
        void Load(string filename);

    }
}
