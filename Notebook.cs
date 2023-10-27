using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Models
{
    internal class Notebook :Product
    {
        //field
        public string _brand;
        public string _model;
        public byte _ram;
        public byte _storage;

        //properties
        public string Brand { get=> _brand; set 
            {
                if(value.Length>3 && value.Length < 30)
                {
                    _brand = value;
                }
                else
                {
                    Console.WriteLine("That is not correct");
                }
            }
        }
        public byte Ram { get=>_ram; set
            {
                if (value > 0 && value<128)
                {
                    _ram = value;
                }
                else
                {
                    Console.WriteLine("Not correct");
                }                
            } 
        }
        public byte Storage { get=>_storage; set 
            {
                if (value > 0)
                {
                    _storage = value;
                }
                else
                {
                    Console.WriteLine("Not correct");
                }
            } }

        //constructor
        public Notebook(string model , int count, decimal price):base(count,price)
        {
            _model = model;
        }
    }
}
