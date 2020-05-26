using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSI
{
    public class StoreItem
    {
        public enum Type { character, skin};
        public int id;
        public string name;
        public string image;
        public int money;
        public int gems;
        public bool bought;
        public Type type;
        public string profImage;

        public StoreItem() { }
        
    }
    class Items
    {
        public Items() { }
        public static List<StoreItem> items_ = new List<StoreItem>()
        {
            new StoreItem()
            {
                id = 0,
                name = "Character1",
                image = "Assets/Character1.png",
                money = 50,
                gems= 0,
                bought = false,
                type = StoreItem.Type.character,
                profImage = "Assets/Portrait1.png"
             },

            new StoreItem()
            {
                id = 1,
                name = "Character2",
                image = "Assets/Character2.png",
                money = 50,
                gems= 0,
                bought = false,
                type = StoreItem.Type.character,
                profImage = "Assets/Portrait2.png"

             },

            new StoreItem()
            {
                id = 2,
                name = "Character3",
                image = "Assets/Character3.png",
                money = 50,
                gems= 0,
                bought = false,
                type = StoreItem.Type.character,
                profImage = "Assets/Portrait3.png"

             },

            new StoreItem()
            {
                id = 3,
                name = "FeaturedCharacter",
                image = "Assets/CharactersBattlePass.png",
                money = 50,
                gems= 0,
                bought = false,
                type = StoreItem.Type.character,
                profImage = "Assets/Portrait4.png"
             },

            new StoreItem()
            {
                id = 4,
                name = "Skin1",
                image = "Assets/Skin1.png",
                money = 0,
                gems = 3,
                bought = false,
                type = StoreItem.Type.skin
             },

            new StoreItem()
            {
                id = 5,
                name = "Skin2",
                image = "Assets/Skin2.png",
                money = 0,
                gems = 3,
                bought = false,
                type = StoreItem.Type.skin
             },

            new StoreItem()
            {
                id = 0,
                name = "Skin3",
                image = "Assets/Skin3.png",
                money = 0,
                gems = 3,
                bought = false,
                type = StoreItem.Type.skin
             },

            new StoreItem()
            {
                id = 0,
                name = "Skin4",
                image = "Assets/Skin4.png",
                money = 0,
                gems = 3,
                bought = false,
                type = StoreItem.Type.skin
             },

            new StoreItem()
            {
                id = 0,
                name = "SkinBattlePass",
                image = "Assets/SkinBattlePass.png",
                money = 0,
                gems = 3,
                bought = false,
                type = StoreItem.Type.skin
             }
        };
        public static List<StoreItem> boughtItems_ = new List<StoreItem>();
        public static List<StoreItem> getBoughtItems() { return boughtItems_; }

        public static void buyItem(StoreItem item) { 
            boughtItems_.Add(item); 
            items_.Remove(item); }
    }
}
