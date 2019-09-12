using System;
using System.Collections.Generic;

namespace MockAssessment3
{
    public class Town
    {
       
        public List<Villager> villagers = new List<Villager>();

        public Town()
        {
            Villager s1 = new Slacker();
            Villager s2 = new Slacker();
            Villager s3 = new Slacker();
            Villager f = new Farmer();
            villagers.Add(s1);
            villagers.Add(s2);
            villagers.Add(s3);
            villagers.Add(f);

        }

        public int Harvest()
        {
            int total = 0;
            foreach (Villager v in villagers)
            {
                total += v.Farm();
            }
            return total;
        }

        public int CalcFoodConsumption()
        {
            int total = 0;
            foreach (Villager v in villagers)
            {
                total += v.Hunger;

            }
            return total;
        }

        public bool SurviveTheWinter()
        {
            int food = Harvest();
            int hunger = CalcFoodConsumption();

            if (food >= hunger)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
