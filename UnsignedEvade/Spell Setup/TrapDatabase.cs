﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsignedEvade
{
    class TrapDatabase
    {
        public static List<Trap> trapList = new List<Trap>()
        {
            //jinx and caitlyn traps
            new Trap()
            {
                Name = "Cupcake Trap",
                Radius = 100f,
            },
            
            //GP Barrel
            new Trap()
            {
                Name = "Barrel",
                Radius = 325f,
            },
            
            //teemo shroom
            new Trap()
            {
                Name = "Noxious Trap",
                Radius = 125f,
            },

            //shaco box
            new Trap()
            {
                Name = "Jack In The Box",
                Radius = 300f,
            },

            //Zyra plants
            new Trap()
            {
                Name = "Seed",
                Radius = 75f,
            },
        };

        public static string[] AllTrapNames()
        {
            string[] names = new string[trapList.Count];
            for (int i = 0; i < names.Length; i++)
                names[i] = trapList[i].Name;
            return names;
        }

        public static Trap getTrap(string name)
        {
            foreach (Trap trap in trapList)
                if (trap.Name == name)
                    return trap;
            return null;
        }
    }
}
