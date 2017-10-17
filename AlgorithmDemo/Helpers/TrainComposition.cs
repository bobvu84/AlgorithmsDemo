using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo.Helpers
{

    public class TrainComposition
    {
        //private List<int> trainCompositions;
        private Dictionary<int, int> dict; //SortedDictionary<int,int> which is the best as it based on Binary Search Tree
        int min = 0, max = 1;
        public TrainComposition()
        {
            //trainCompositions = new List<int>();
            dict = new Dictionary<int, int>();
        }
        public void AttachWagonFromLeft(int wagonId)
        {
            
            dict.Add(min, wagonId);
            min = min - 1;

            //trainCompositions.Insert(0, wagonId);

        }

        public void AttachWagonFromRight(int wagonId)
        {
            
            dict.Add(max, wagonId);
            max = max + 1;
            //trainCompositions.Insert(trainCompositions.Count, wagonId);

        }

        public int DetachWagonFromLeft()
        {
             
            //int result = trainCompositions[0];
            //trainCompositions.RemoveAt(0);

            int result1;
            dict.TryGetValue(min+1, out result1);
            dict.Remove(min+1);
            min = min + 1;

            return result1;
            
        }

        public int DetachWagonFromRight()
        {
            //int result = trainCompositions[trainCompositions.Count - 1];
            //trainCompositions.RemoveAt(trainCompositions.Count - 1);


            int result2;
            dict.TryGetValue(max-1, out result2);
            dict.Remove(max-1);
            max = max - 1;

            return result2;
           
        }

        public static void Main(string[] args)
        {
            TrainComposition tree = new TrainComposition();
            tree.AttachWagonFromLeft(7);
            tree.AttachWagonFromLeft(13);
            Console.WriteLine(tree.DetachWagonFromRight()); // 7 
            Console.WriteLine(tree.DetachWagonFromLeft()); // 13
        }
    }
}
