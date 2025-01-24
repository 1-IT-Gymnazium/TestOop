using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOop
{
    public class Trek
    {
        public double Length { get; set; }
        public int Difficulty { get; set; }
        public int BogFactor { get; set; }
        public Trek(int length, int difficulty, int bogFactor ) 
        {
            Length = length;
            Difficulty = difficulty;
            BogFactor = bogFactor;
        }
        public int GetTime()
        {
            int avgSpeed;    
            int Time = 0;
            
           return $"Čas {Time}" 
        }
        public int PrintInfo()
        {
            Console.WriteLine($" Délka Treku  {Length} km" );
            Console.WriteLine($"Obtížnost Treku {Difficulty}");
            Console.WriteLine($" Bažinatost Treku {BogFactor}");
           
        }

    }
}
