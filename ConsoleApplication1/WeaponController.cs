﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class WeaponController
    {
        private Weapon primaryWeapon { get; set; }
        private Weapon sideArm { get; set; }
        
        public WeaponController(Weapon first, Weapon second)
        {
            primaryWeapon = first;
            sideArm = second;
        }

        public void FirePrimary()
        {
            Console.Out.WriteLine("Primary Weapon Fired");
        }

        public void FireSecondary()
        {
            Console.Out.WriteLine("Sidearm Fired");
        }

        public void ReloadPrimary()
        {
            Console.Out.WriteLine("Primary Weapon reloaded");
        }

        public void ReloadSecondary()
        {
            Console.Out.WriteLine("Sidearm reloaded");
        }

    }
}
