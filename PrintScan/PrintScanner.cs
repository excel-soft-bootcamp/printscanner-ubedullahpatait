using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScan
{
    class PrintScanner: IPrinter,IScanner

    {
       IPrinter printer;

        IScanner scanner;
        public void SetPrinter(IPrinter printerRef)
        {
            this.printer = printerRef;
        }
        public void SetScanner(IScanner scanRef)
        {

            this.scanner = scanRef;
        }


        public void Print()
        {
          
            this.printer.Print();
        }

        public void Scan()
        {
          
            this.scanner.Scan();
        }
       

    }
}
