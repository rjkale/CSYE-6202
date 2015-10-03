using System;

namespace BoxingWeights
{
class Program
 {
  static void Main(string[] args)
  {
   while (true)
   {
    Console.WriteLine("Enter your weight to Determince your weight classification");
    int weight = Convert.ToInt32(Console.ReadLine());
    BoxingWeightClassifier bw = new BoxingWeightClassifier();
    string output = bw.ClassifyBoxingWeight(weight);

    Console.WriteLine(output);
    Console.ReadLine();
   }
  }
 }
}
