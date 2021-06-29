using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScan
{
    class PrintScanner: IPrinter,IScanner

    {
       public  Scanner scan(Scanner _scan)
        {
            return _scan;  
        }

        public Printer print(Printer _print)
        {
            return _print;
        }
       

    }
}
