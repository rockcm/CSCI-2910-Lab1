///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 1 
//	File Name:         Driver.cs
//	Description:       Review over interfaces and C# concepts and create game lists. 
//	Course:            CSCI-2910
//	Author:            Christian Rock, rockcm@etsu.edu, East Tennessee State University
//	Created:           08/29/2023
//	Copyright:         Christian Rock, 2023
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/// <summary>
/// Driver class to demonstrate use of icomparable on a video game list. 
/// </summary>

using Lab1;
using System.Collections.Generic;
using System.Runtime.CompilerServices;





// variables 
List<VideoGame> videoGames = new List<VideoGame>();
StreamReader streamReader = null;
List<VideoGame> GenreList = new List<VideoGame>();
List<VideoGame> PubList = new List<VideoGame>();

// try catch for streamreader 
try
    {
        

        // creating a stream reader to read in the file given. 
        streamReader = new StreamReader(@"../../../gameList/videogames.csv");

        streamReader.ReadLine(); // reading first line of document
        // while stream reader is not at the end of doc, continue loop. 
        while (streamReader.Peek() != -1)
        {
            // splitting each line read in to fiels that can be accessed and used to create videogame item. 
            string textLine = streamReader.ReadLine();
            string[] fields = textLine.Split(",");
            VideoGame Videogame = new VideoGame(fields[0], fields[1], fields[2], fields[3], fields[4], Convert.ToDecimal(fields[5]), Convert.ToDecimal(fields[6]), Convert.ToDecimal(fields[7]), Convert.ToDecimal(fields[8]), Convert.ToDecimal(fields[9]));
            videoGames.Add(Videogame);
       
            
        }
      


  }
    catch (FormatException e) 
    { 
        Console.WriteLine($"{e.Message}"); 
    }
    catch (Exception e)
    {
    Console.WriteLine(e.Message);
    }


    finally // makes sure reader closes regardless
    {
        if (streamReader != null)
        streamReader.Close();
    }

// sorting games by name
videoGames.Sort();

// printing out all games after sort 
for(int i = 0; i < videoGames.Count; i++)
{
    Console.WriteLine(videoGames[i]);
}




// adding games to list that match publisher
foreach (VideoGame videoGame in videoGames)
{
    if(videoGame.publisher == "Nintendo")
    {
        PubList.Add(videoGame);
    }
}

//displaying publisher list
for(int i = 0; i < PubList.Count; i++)
{
    Console.WriteLine(PubList[i]);
}



// adding games to list that match genre
foreach (VideoGame videoGame in videoGames)
{
    if(videoGame.genre == "Shooter")
    {
        GenreList.Add(videoGame);
    }
}

//displaying genre list
for (int i = 0; i < GenreList.Count; i++)
{
    Console.WriteLine(GenreList[i]);
}

// displaying publisher and genre list percents 
Console.WriteLine(Math.Round(PubList.Count * 100.0 / videoGames.Count, 2) + "%");

Console.WriteLine(Math.Round(GenreList.Count * 100.0 / videoGames.Count, 2) + "%");


//calling methods 
PublisherData();
GenreData();

// method that allows the user to enter a publisher to create a list for and displays that list 
  void PublisherData()
{
    Console.WriteLine("Please enter a publisher");
    string userInput = Console.ReadLine();
    List<VideoGame> data = new List<VideoGame>();
    foreach (VideoGame vid in videoGames)
    {
        if (userInput == vid.publisher)
        {
            data.Add(vid);
        }
    }

    foreach (VideoGame videoGame in data)
    {
        Console.WriteLine(videoGame);
    }
}

// method that allows the user to enter a genre to create a list for and displays that list 
void GenreData()
{
    Console.WriteLine("Please enter a genre");
    string userInput = Console.ReadLine();
    List<VideoGame> data = new List<VideoGame>();
    foreach (VideoGame vid in videoGames)
    {
        if (userInput == vid.genre)
        {
            data.Add(vid);
        }
    }

    foreach (VideoGame videoGame in data)
    {
        Console.WriteLine(videoGame);
    }
}