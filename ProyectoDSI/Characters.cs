using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace ProyectoDSI
{
    public class Character
    {
        public enum Ability { Armor, Engine, Wheels };

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public string Explicacion { get; set; }
        public Ability ability { get; set; }
        public Character() { }
    }

    public class Characters
    {
        public static IList<Character> GetCharacters() { return Characters_; }
        public static Character GetCharacterByID(int id)
        {
            if (id < 0 || id >= Characters_.Count()) return null;
            else return Characters_[id];
        }

        public static List<Character> Characters_ = new List<Character>()
        {
            new Character()
            {
                Id = 0,
                Nombre = "Character1",
                Imagen = "../Assets/Armor.png",
                Explicacion = @"Explicación Character1 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                ability = Character.Ability.Armor,
             },
            new Character()
            {
                Id = 1,
                Nombre = "Character2",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Character2 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                ability = Character.Ability.Armor,
             },
            new Character()
            {
                Id = 2,
                Nombre = "Character3",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Character3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                ability = Character.Ability.Armor,
             },
            new Character()
            {
                Id = 3,
                Nombre = "Character4",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Character4 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                ability = Character.Ability.Armor,
             },
            new Character()
            {
                Id = 4,
                Nombre = "Character5",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Character5 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                ability = Character.Ability.Engine,
             },
            new Character()
            {
                Id = 5,
                Nombre = "Character6",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Character6 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                ability = Character.Ability.Engine,
             },
            new Character()
            {
                Id = 6,
                Nombre = "Character7",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Character7 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                ability = Character.Ability.Engine,
             },
            new Character()
            {
                Id = 7,
                Nombre = "Character8",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Character8 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                ability = Character.Ability.Engine,
             },
            new Character()
            {
                Id = 8,
                Nombre = "Character9",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Character9 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                ability = Character.Ability.Wheels,
             },
            new Character()
            {
                Id = 9,
                Nombre = "Character10",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Character10 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                ability = Character.Ability.Wheels,
             },
             new Character()
            {
                Id = 10,
                Nombre = "Character11",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Character11 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                ability = Character.Ability.Wheels,
             },
              new Character()
            {
                Id = 11,
                Nombre = "Character12",
                Imagen = "Assets/Armor.png",
                Explicacion = @"Explicación Character12 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                ability = Character.Ability.Wheels,
             }

          };
    }
    public class VCharacters : Character
    {
        public Image img;
        public ContentControl CCImg;
        public RotateTransform rotation;
        public int angle;
        public int Zoom;
        public VCharacters(Character upgr)
        {
            Id = upgr.Id;
            Nombre = upgr.Nombre;
            Imagen = upgr.Imagen;
            ability = upgr.ability;

            img = new Image();
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + upgr.Imagen;
            img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            img.Width = 50;
            img.Height = 50;
            CCImg = new ContentControl();
            CCImg.Content = img;
            CCImg.UseSystemFocusVisuals = true;
            CCImg.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }


    }
}
