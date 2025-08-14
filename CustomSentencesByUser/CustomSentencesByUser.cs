using System;

namespace CustomSentencesByUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Daniel", "Yordan", "Vasilina", "Viktor", "Alex", "Sasho" };
            string[] places = { "Kyustendil", "Sofia", "Varna", "Plovdiv", "Burgas" };
            string[] verbs = { "catches", "chases", "kicks", "teleports", "feeds", "rides" };
            string[] nouns = { "a sleepy panda", "an invisible hamster", "a ninja pineapple", "a crying cloud", "a teleporting llama" };
            string[] adverbs = { "with zero shame", "with great confidence", "while breakdancing", "like a ninja", "happily" };
            string[] details = { "while riding a unicorn", "in a secret room", "underwater", "in a parallel universe", "in a pirate ship" };

            string GetRandomWord(string[] words)
            {
                Random random = new Random();

                int randomIndex = random.Next(words.Length);
                string word = words[randomIndex];
                return word;
            }

            Console.WriteLine("Hello, this is your first random-generated sentence: ");
            while (true)
            {
                string randomName = GetRandomWord(names);
                string randomPlace = GetRandomWord(places);
                string randomVerb = GetRandomWord(verbs);
                string randomNoun = GetRandomWord(nouns);
                string randomAdverb = GetRandomWord(adverbs);
                string randomDetail = GetRandomWord(details);

                string who = $"{randomName} from {randomPlace}";
                string action = $"{randomAdverb} {randomVerb} {randomNoun}";
                string sentence = $"{who} {action} {randomDetail}";

                Console.WriteLine(sentence);
                Console.WriteLine("Click [Enter] to generate a new one");
                Console.ReadLine();
            }
        }

    }
}
