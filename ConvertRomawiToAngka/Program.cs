using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertRomawiToAngka
{
    class Program
    {
        static void Main(string[] args)
        {
            AngkaRomawi data1 = new AngkaRomawi() { romawi = 'I', angka = 1 };
            AngkaRomawi data2 = new AngkaRomawi() { romawi = 'V', angka = 5 };
            AngkaRomawi data3 = new AngkaRomawi() { romawi = 'X', angka = 10 };
            AngkaRomawi data4 = new AngkaRomawi() { romawi = 'L', angka = 50 };
            AngkaRomawi data5 = new AngkaRomawi() { romawi = 'C', angka = 100 };
            AngkaRomawi data6 = new AngkaRomawi() { romawi = 'D', angka = 500 };
            AngkaRomawi data7 = new AngkaRomawi() { romawi = 'M', angka = 1000 };

            List<AngkaRomawi> listNilaiRomawi = new List<AngkaRomawi>();
            listNilaiRomawi.Add(data1);
            listNilaiRomawi.Add(data2);
            listNilaiRomawi.Add(data3);
            listNilaiRomawi.Add(data4);
            listNilaiRomawi.Add(data5);
            listNilaiRomawi.Add(data6);
            listNilaiRomawi.Add(data7);

            Console.Write("inputkan angka romawi : ");
            char[] nRomawi = Console.ReadLine().ToUpper().ToCharArray();
            int count = nRomawi.Length;
            int output = 0;
            for (int i = 0; i < count; i++)
            {                
                if (i==count-1)
                {
                    int fRomawi = listNilaiRomawi.Find(x => x.romawi == nRomawi[i]).angka;
                    output += fRomawi;
                }
                else
                {
                    int fRomawi = listNilaiRomawi.Find(x => x.romawi == nRomawi[i]).angka;
                    int sRomawi = listNilaiRomawi.Find(x => x.romawi == nRomawi[i + 1]).angka;
                    if (fRomawi >= sRomawi)
                    {
                        output += fRomawi;
                    }
                    else
                    {
                        int hPengurangan = sRomawi - fRomawi;
                        output += hPengurangan;
                        i++;
                    }
                }
            }
            Console.WriteLine("cek output {0}", output);
            Console.ReadKey();
        }
    }
    
}
