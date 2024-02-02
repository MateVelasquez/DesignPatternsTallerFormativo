using DesignPatterns.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Infraestructure.Singleton
{
    public class MemoryColletion
    {

        private static MemoryColletion _instance;
        
        public ICollection<Vehicle> Vehicles { get; set; }
        
        private MemoryColletion()
        {
            Vehicles = new List<Vehicle>();
        }

        public static MemoryColletion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MemoryColletion();
                }
                return _instance;
            }
        }
    }
}
