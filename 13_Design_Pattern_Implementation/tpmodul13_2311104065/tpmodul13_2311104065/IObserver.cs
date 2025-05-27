using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul13_2311104065
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}
