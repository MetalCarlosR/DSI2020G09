using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace MadRacing
{
    public class Upgrade
    {
        public enum type { Armor, Engine, Wheels };

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public string Explicacion { get; set; }
        public type Type { get; set; }
        public Upgrade() { }
    }

    public class Upgrades
    {
        public static IList<Upgrade> GetUpgrades() { return upgrades_; }
        public static Upgrade GetUpgradeByID(int id)
        {
            if (id < 0 || id >= upgrades_.Count()) return null;
            else return upgrades_[id];
        }

        public static List<Upgrade> upgrades_ = new List<Upgrade>()
        {
            new Upgrade()
            {
                Id = 0,
                Nombre = "Upgrade1",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Upgrade1 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Type = Upgrade.type.Armor,
             },
            new Upgrade()
            {
                Id = 1,
                Nombre = "Upgrade2",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Upgrade2 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Type = Upgrade.type.Armor,
             },
            new Upgrade()
            {
                Id = 2,
                Nombre = "Upgrade3",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Upgrade3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Type = Upgrade.type.Armor,
             },
            new Upgrade()
            {
                Id = 3,
                Nombre = "Upgrade4",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Upgrade4 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Type = Upgrade.type.Armor,
             },
            new Upgrade()
            {
                Id = 4,
                Nombre = "Upgrade5",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Upgrade5 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Type = Upgrade.type.Engine,
             },
            new Upgrade()
            {
                Id = 5,
                Nombre = "Upgrade6",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Upgrade6 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Type = Upgrade.type.Engine,
             },
            new Upgrade()
            {
                Id = 6,
                Nombre = "Upgrade7",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Upgrade7 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Type = Upgrade.type.Engine,
             },
            new Upgrade()
            {
                Id = 7,
                Nombre = "Upgrade8",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Upgrade8 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Type = Upgrade.type.Engine,
             },
            new Upgrade()
            {
                Id = 8,
                Nombre = "Upgrade9",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Upgrade9 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Type = Upgrade.type.Wheels,
             },
            new Upgrade()
            {
                Id = 9,
                Nombre = "Upgrade10",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Upgrade10 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Type = Upgrade.type.Wheels,
             },
             new Upgrade()
            {
                Id = 10,
                Nombre = "Upgrade11",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Upgrade11 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Type = Upgrade.type.Wheels,
             },
              new Upgrade()
            {
                Id = 11,
                Nombre = "Upgrade12",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Upgrade12 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Type = Upgrade.type.Wheels,
             }

          };
    }
    public class VUpgrades : Upgrade
    {
        public Image img;
        public ContentControl CCImg;
        public RotateTransform rotation;
        public int angle;
        public int Zoom;
        public VUpgrades(Upgrade upgr)
        {
            Id = upgr.Id;
            Nombre = upgr.Nombre;
            Imagen = upgr.Imagen;
            Explicacion = upgr.Explicacion;
            Type = upgr.Type;

            img = new Image();
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + upgr.Imagen;
            img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            img.Width = 50;
            img.Height = 50;
            CCImg = new ContentControl();
            CCImg.RenderTransform = rotation;
            CCImg.Content = img;
            CCImg.UseSystemFocusVisuals = true;
            CCImg.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }


    }
}
