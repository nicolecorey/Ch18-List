namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> dogBreeds = new List<string> { "Golden Retriever", "Poodle", "Terrier", "Chihuahua", "Dalmation" };

            string[] breedArr = new string[] { "Dachsund", "Husky", "Collie" };
            dogBreeds.AddRange(breedArr);
            Console.WriteLine($"This list shows {dogBreeds.Count()} dog breeds.");

            Console.WriteLine("--Original List--");
            for (int i = 0; i < dogBreeds.Count(); i++)

            dogBreeds.Sort();
            foreach (string b in dogBreeds)
                Console.WriteLine(b);
            Console.WriteLine();

            dogBreeds.Remove("Terrier");

            Console.WriteLine($"The revised list now has {dogBreeds.Count()} dog breeds.");
            Console.WriteLine("--Updated dog breeds--");
            for (int i = 0; i < dogBreeds.Count(); i++)
                Console.WriteLine(dogBreeds[i]);
            Console.WriteLine();

            
            dogBreeds.Reverse();
            Console.WriteLine("--Reverse list of dog breeds--");
            foreach (string b in dogBreeds)
                Console.WriteLine(b);

        }
    }
}
