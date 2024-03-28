
using System.Security.Cryptography;

namespace TamagotchiCSharpThreading
{
    public class Tamagotchi
    {
        private string Name;
        private string Type;
        private int Attention;
        private bool Dead;
        private string FilePath;
        private int Food;
        private int Sleep;

        public Tamagotchi(string name, string type)
        {
            Name = name;
            Type = type;
            Attention = 15;
            Food = 15;
            Sleep = 15;
            Dead = false;
            FilePath = "filePath";
        }

        public string GetName() {  return Name; }
        public void SetName(string name) { Name = name; }

        public int GetFoodLevel()
        {
            return Food;
        }

        public void SetFoodLevel(int num)
        {
            Food += num;
        }

        public int GetSleepLevel()
        {
            return Sleep;
        }

        public void SetSleepLevel(int num)
        {
            Sleep += num;
        }

        public int GetAttentionLevel()
        {
            return Attention;
        }

        public void SetAttentionLevel(int num)
        {
            Attention += num;
        }
        public void IsDead()
        {
            if (Food <= 0 || Sleep <= 0 || Attention <= 0)
            {
                Dead = true;
            }
            else
            {
                Dead = false;
            }
        }

        public bool GetIsDead()
        {
            return Dead;
        }

       /* public static List<Pet> GetAll()
        {
            return _instances;
        }
        public static Pet Find(int searchId)
        {
            return _instances[searchId - 1];
        }
        public int GetId()
        {
            return _id;
        }*/
    }
}
