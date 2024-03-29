using System.Collections.Generic;

namespace TamagotchiList.Models
{
    public class Tamagotchi
    {
        public string Description { get; set; }
        public int FoodLevel { get; set; }
        public int AttentionLevel { get; set; }
        public int SleepLevel { get; set; }
        public int Id { get; }
        private static List<Tamagotchi> _instances = new List<Tamagotchi> { };

        public Tamagotchi(string description, int foodLevel, int attentionLevel, int sleepLevel)
        {
            Description = description;
            this.FoodLevel = 5;
            this.AttentionLevel = 5;
            this.SleepLevel = 5;

            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Tamagotchi> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Tamagotchi Find(int searchId)
        {
            return _instances[searchId - 1];
        }

        public List<Tamagotchi> deadList = new List<Tamagotchi> { };


    }
}