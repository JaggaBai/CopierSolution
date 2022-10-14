using System;
using System.Collections.Generic;
using System.Text;
using ver1;

namespace Zadanie1
{
    class Copier : IPrinter, IScanner
    {

        //  property PrintCounter zwraca aktualną liczbę wydrukowanych dokumentów,
        public int PrintCounter
        {
            get
            {
               
            }
        }


        //property ScanCounter zwraca liczbę zeskanowanych dokumentów,
        public int ScanCounter
        {
            get
            {
            }
        }

        //property Counter zwraca liczbę uruchomień kserokopiarki
        public int Counter
        {
            get
            {
            }
        }


        //Jeśli kserokopiarka jest wyłączona, wysyłanie do niej zadań nie ma żadnego skutku i żadnej reakcji z jej strony.



        public IDevice.State GetState()
        {

        }

        public void PowerOff()
        {
            //Włączanie urządzenia, które jest już włączone, nie przynosi żadnego skutku. Analogicznie dla wyłączania urządzenia.
            if (GetState() == IDevice.State.on)
                PowerOff();

        }

        public void PowerOn()
        {
            if (GetState() == IDevice.State.off)
              PowerOn();
            //Włączanie urządzenia, które jest już włączone, nie przynosi żadnego skutku. Analogicznie dla wyłączania urządzenia.
        }

        public void Print(in IDocument document)
        {
            //Metoda Print() wypisuje na konsolę datę i godzinę wydruku, słowo Print oraz nazwę drukowanego dokumentu Przykład: 15.11.2020 22:31:13 Print: aaa.pdf
        }

        public void Scan(out IDocument document, IDocument.FormatType formatType)
        {

            //        Metoda Scan() wypisuje na konsolę datę i godzinę skanu, słowo Scan oraz nadaną nazwę pliku zeskanowanego dokumentu w formacie:

            //dla dokumentów typu PDF: PDFScanXXXX.pdf, gdzie XXXX oznacza numer skanowanego dokumentu od pierwszego uruchomienia kserokopiarki,
            //dla dokumentów typu JPG: ImageScanXXXX.jpg, gdzie XXXX oznacza numer skanowanego dokumentu od pierwszego uruchomienia kserokopiarki,
            //dla dokumentów typu TXT: TextScanXXXX.txt, gdzie XXXX oznacza numer skanowanego dokumentu od pierwszego uruchomienia kserokopiarki.

            //Przykład: 15.11.2020 22:31:13 Scan: ImageScan1.jpg
            
        }

        public void ScanAndPrint()
        {
            //Metoda ScanAndPrint() wykonuje skanowanie(do JPG) i natychmiastowy wydruk zeskanowanego dokumentu.
}
    }
}
