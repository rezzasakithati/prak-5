using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace void_overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            number numbers = new number();
            numbers.CariNilaiMin(45, 21);
            numbers.CariNilaiMin(27, 56, 54);
            numbers.CariNilaiMax(23, 34);
            numbers.CariNilaiMax(53, 51, 50);
        }
    }
}