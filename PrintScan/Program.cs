using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScan
{
    class Program
    {
        static void Main(string[] args)


        {
          Printer printer = new Printer();
            Scanner scanner = new Scanner();
            NanoLaserPrinter nanoLaserPrinter = new NanoLaserPrinter();

            PrintManager printManager = new PrintManager();
            printManager.PrintDocument(printer);

            ScanManager scanManager = new ScanManager();
            scanManager.ScanDocument(scanner);

            PrintScanner printScan = new PrintScanner();
            printScan.SetPrinter(printer);
            
            printScan.SetScanner(scanner);

            printManager.PrintDocument(printScan);
            scanManager.ScanDocument(printScan);

            Console.ReadKey();



        }
    }
}
