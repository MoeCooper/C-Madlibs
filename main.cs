using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      
      string author = "Maurice C.";
      Console.WriteLine("This is a Madlibs project!");
      Console.WriteLine($"The author is {author}");

      Console.WriteLine("");
      Console.WriteLine("The program is beginning....");
      Console.WriteLine("");
      string title = "Once upon a time, long long ago.";

      Console.WriteLine(title);

      Console.Write("What\'s your name?: ");
      string userName = Console.ReadLine();

      Console.Write("What\'s your favorite color?: ");
      string userColor = Console.ReadLine();

      Console.Write("What kind of feeling do you have right now?: ");
      string userFeeling = Console.ReadLine();

      Console.Write("What kind of texture do you like?: ");
      string userTexture = Console.ReadLine();

      Console.Write("What\'s your favorite verb?: ");
      string userVerb = Console.ReadLine();

      Console.Write("Give me one noun: ");
      string userNounOne = Console.ReadLine();

      Console.Write("Give me another verb: ");
      string userNounTwo = Console.ReadLine();

      Console.Write("What\'s your favorite animal?: ");
      string userAnimal = Console.ReadLine();

      Console.Write("What\'s your favorite food?: ");
      string userFood = Console.ReadLine();

      Console.Write("What\'s your favorite fruit?: ");
      string userFruit = Console.ReadLine();

      Console.Write("Who is your favorite superhero?: ");
      string userHero = Console.ReadLine();

      Console.Write("What\'s your favorite country?: ");
      string userCountry = Console.ReadLine();

      Console.Write("What\'s your favorite dessert?: ");
      string userDessert = Console.ReadLine();

      Console.Write("Enter a year: ");
      string userYear = Console.ReadLine();


      string story = $"This morning {userName} woke up feeling {userColor}. 'It is going to be a {userFeeling} day!' Outside, a bunch of {userAnimal}s were protesting to keep {userFood} in stores. They began to {userVerb} to the rhythm of the {userNounOne}, which made all the {userFruit}s very {userTexture}. Concerned, {userName} texted {userHero}, who flew {userName} to {userCountry} and dropped {userName} in a puddle of frozen {userDessert}. {userName} woke up in the year {userYear}, in a world where {userNounTwo}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);

    }
  }
}
