namespace generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [34,21,34,98, 98] => [34,98]
            List<int> testList = new List<int> { 34, 21, 34, 98, 98 };
            List<int> dupList = Duplicates(testList);
            Console.WriteLine("Input List: " + String.Join(",", testList));
            Console.WriteLine("Output List: " + String.Join(",", dupList));

            // [apa,bpa,cpa,bpa] => [bpa]
            List<string> testList2 = new List<string> { "apa", "bpa", "cpa", "bpa" };
            List<string> dupList2 = Duplicates(testList2);
            Console.WriteLine("Input List 2: " + String.Join(",", testList2));
            Console.WriteLine("Output List 2: " + String.Join(",", dupList2));
        }

        public static List<T> Duplicates<T>(List<T> minLista)
        {
            List<T> result = new List<T>();

            
            for (int i = 0; i < (minLista.Count - 1); i++)
            {
                for(int k = i+1; k < (minLista.Count); k++)
                {
                    if (EqualityComparer<T>.Default.Equals(minLista[i], minLista[k]))
                    {
                        if (result.Contains(minLista[i]))
                        {

                        }
                        else
                        {
                            result.Add(minLista[i]);
                        }

                    }
                }
            }

            return result;
        }




    }
}
