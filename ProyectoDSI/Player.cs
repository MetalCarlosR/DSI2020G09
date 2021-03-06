﻿using System;
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

    struct Challenge
    {
        public Challenge(string s, int acV, int mV, bool com)
        {
            message = s;
            actualValue = acV;
            maxValue = mV;
            completed = com;
        }
        public string message;
        public int actualValue;
        public int maxValue;
        public bool completed;
    }

    // Best if singleton
    class Player
    {
        public Player() { }

        public static int gold { get; set; } = 1530;
        public static int gems { get; set; } = 565;

        public static int role = 0;

        public static StoreItem character = null;

        public static Icono icono { get; set; } = Iconos.iconos_[0];

        public static List<Challenge> dailyChallenge = new List<Challenge>()
        {
            new Challenge("Play one game", 1,1 , true),
            new Challenge("Drive 10 km",7,10 , false),
            new Challenge("Kill 10 players", 10,10 , true),
            new Challenge("Get top 3 in one game", 1,1 , true)
        };

        public static List<Challenge> weeklyChallenge = new List<Challenge>()
        {
            new Challenge("Win 10 games", 9,10, false),
            new Challenge("Win 3 Battle Royale games",3,3 , true),
            new Challenge("Play Driver role in 20 games",2,20, false),
            new Challenge("Kill 150 players",134,150 , false)
        };

        public static void addGold(int g) { gold += g; }
        public static void addGems(int g) { gems += g; }

        public static void removeGold(int g) { gold -= g; }
        public static void removeGems(int g) { gems -= g; }

    }
}
