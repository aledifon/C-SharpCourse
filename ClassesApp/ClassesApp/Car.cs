﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    //It's internal, which means that 
    //it can only be accessed from 
    //within the same assembly (= same Program)
    //An assembly is mainly a DLL or a .EXE.
    internal class Car
    {
        // member variable
        // private hides the variable from other classes
        private string _model = "";

        private string _brand = "";

        private bool _isLuxury;

        // Property        
        public string Model { get => _model; set => _model = value; }        
        public string Brand { 
            
            get
            {
                if (_isLuxury)
                    return _brand + " - Luxury Edition";                
                else
                    return _brand;
            } 

            set 
            {   if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered Nothing!");
                    _brand = "DEFAULTVALUE";
                }
                else
                {
                    _brand = value;
                }                        
            }
        }

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        // Custom Constructor
        public Car(string brand, string model, bool isLuxury)
        {
            Model = model;
            Brand = brand;
            Console.WriteLine("A "+ Brand + " car of the model " 
                            + Model + " has been created");
            IsLuxury = isLuxury;
        }        
    }
}
