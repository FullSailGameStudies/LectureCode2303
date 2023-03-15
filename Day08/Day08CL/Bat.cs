using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08CL
{
    public enum Material
    {
        Wood, Aluminum, Nerf
    }

    public class Bat : Weapon
    {
        public Material BatMaterial { get; set; }

        public Bat(Material batMaterial, int range, int damage) : base(range, damage)
        {
            BatMaterial = batMaterial;
        }

        public override void ShowMe()
        {
            base.ShowMe();
            Console.WriteLine($"It's a {BatMaterial} bat.");
        }
    }
}
