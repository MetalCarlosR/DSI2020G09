using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSI
{
    public class Friend
    {
        public int id;
        public string name;
        public string image;

        public Friend() { }
    }

    public class Friends
    {
        public static List<Friend> friends_ = new List<Friend>()
        {
            
            new Friend()
            {
                id = 0,
                name = "NicoGalactico",
                image = ""
            },
            new Friend()
            {
                id = 1,
                name = "AnaMaraca",
                image = ""
            },
            new Friend()
            {
                id = 2,
                name = "CarlosCosaco",
                image = ""
            },
            new Friend()
            {
                id = 3,
                name = "RicardoMosaico",
                image = ""
            }
        };
        
        public static List<Friend> getFriends() { return friends_; }
        public static Friend GetFriendById(int id) { return friends_[id]; }
        public static void addFriend(Friend f) { friends_.Add(f); }
        public static void removeFriend(Friend f) { friends_.Remove(f); }
    }

    // Best if singleton
    class Player
    {
        public Player() { }

        public static int gold { get; set; } = 1530;
        public static int gems { get; set; } = 565;

        public static void addGold(int g) { gold += g; }
        public static void addGems(int g) { gems += g; }

        public static void removeGold(int g) { gold -= g; }
        public static void removeGems(int g) { gems -= g; }
    }
}
