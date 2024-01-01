using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ZidererA.CommonFuncCSharp.Models;

namespace ZidererA.CommonFuncCSharp.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniNum asd = new float[]{1, 5, 10};
            foreach (var val in asd.GetFloats())
            {
                Console.WriteLine(val);
            }
            asd = 5f;
            foreach (var val in asd.GetFloats())
            {
                Console.WriteLine(val);
            }
            
            
            asd = new ushort[]{ 1, 6, 10};
            foreach (var val in asd.GetUShorts())
            {
                Console.WriteLine(val);
            } 
            asd = (ushort)10;
            foreach (var val in asd.GetUShorts())
            {
                Console.WriteLine(val);
            }
            
            asd = new short[]{ 1, 6, 10};
            foreach (var val in asd.GetUShorts())
            {
                Console.WriteLine(val);
            } 
            asd = (short)10;
            foreach (var val in asd.GetShorts())
            {
                Console.WriteLine(val);
            }
        }
    }
}
