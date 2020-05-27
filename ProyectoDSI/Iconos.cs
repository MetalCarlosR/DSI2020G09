using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSI
{
    class Icono
    {
        public int id;
        public string name;
        public string image;
    }
    class Iconos
    {
        public Iconos() { }
        public static List<Icono> iconos_ = new List<Icono>()
        {
            new Icono()
            {
               id = 0,
               name = "Icono1",
               image = "Assets/Iconos/Icono1.png"
            },
            new Icono()
            {
               id = 1,
               name = "Icono2",
               image = "Assets/Iconos/Icono2.png"
            },
            new Icono()
            {
               id = 2,
               name = "Icono3",
               image = "Assets/Iconos/Icono3.png"
            },
            new Icono()
            {
               id = 3,
               name = "Icono4",
               image = "Assets/Iconos/Icono4.png"
            },
            new Icono()
            {
               id = 4,
               name = "Icono5",
               image = "Assets/Iconos/Icono5.png"
            },
            new Icono()
            {
               id = 5,
               name = "Icono7",
               image = "Assets/Iconos/Icono7.png"
            },
            new Icono()
            {
               id = 6,
               name = "Icono8",
               image = "Assets/Iconos/Icono8.png"
            },
            new Icono()
            {
               id = 7,
               name = "Icono9",
               image = "Assets/Iconos/Icono9.png"
            },
            new Icono()
            {
               id = 8,
               name = "Icono10",
               image = "Assets/Iconos/Icono10.png"
            },
            new Icono()
            {
               id = 9,
               name = "Icono11",
               image = "Assets/Iconos/Icono11.png"
            }
        };
    }
}
