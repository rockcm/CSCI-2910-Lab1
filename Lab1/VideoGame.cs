///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 1 
//	File Name:         game.cs
//	Description:       class to create a game object.  
//	Course:            CSCI-2910
//	Author:            Christian Rock, rockcm@etsu.edu, East Tennessee State University
//	Created:           08/29/2023
//	Copyright:         Christian Rock, 2023
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// class to create cideo game objects 
    /// </summary>
    public class VideoGame : IComparable<VideoGame>
    {
        //properties for videogame object
        public string name { get; set; }
        public string platform { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public string publisher { get; set; }
        public decimal na_Sales { get; set; }
        public decimal eu_Sales { get; set; }
        public decimal jp_Sales { get; set; }
        public decimal other_Sales { get; set; }
        public decimal global_Sales { get; set; }


        /// <summary>
        /// default constructor
        /// </summary>
        public VideoGame()
        {
            this.name= string.Empty;
            this.platform= string.Empty;
            this.year= string.Empty;
            this.genre= string.Empty;
            this.publisher= string.Empty;
            this.na_Sales= 0;
            this.eu_Sales= 0;
            this.jp_Sales= 0;
            this.other_Sales= 0;
            this.global_Sales= 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">name of game</param>
        /// <param name="platform">platform game is on</param>
        /// <param name="year">year game is released</param>
        /// <param name="genre">genre of game</param>
        /// <param name="publisher">publisher of game</param>
        /// <param name="na_Sales">na sales for game</param>
        /// <param name="eu_Sales">eu sales for game</param>
        /// <param name="jp_Sales">jp sales for game</param>
        /// <param name="other_Sales">other sales for game</param>
        /// <param name="global_Sales">global sales for game</param>
        public VideoGame(string name, string platform, string year, string genre, string publisher, decimal na_Sales, decimal eu_Sales, decimal jp_Sales, decimal other_Sales, decimal global_Sales)
        {
            this.name = name;
            this.platform = platform;
            this.year = year;
            this.genre = genre;
            this.publisher = publisher;
            this.na_Sales = na_Sales;
            this.eu_Sales = eu_Sales;
            this.jp_Sales = jp_Sales;
            this.other_Sales = other_Sales;
            this.global_Sales = global_Sales;
        }
        /// <summary>
        /// copy constructor 
        /// </summary>
        /// <param name="videoGame"> video game object</param>
        public VideoGame(VideoGame videoGame)
        {
            this.name= videoGame.name;
            this.platform= videoGame.platform;
            this.year= videoGame.year;
            this.genre= videoGame.genre;
            this.publisher= videoGame.publisher;
            this.na_Sales= videoGame.na_Sales;
            this.eu_Sales= videoGame.eu_Sales;
            this.jp_Sales= videoGame.jp_Sales;
            this.other_Sales= videoGame.other_Sales;
            this.global_Sales= videoGame.global_Sales;
        }
        /// <summary>
        /// comapares the name of one videogame object to another
        /// </summary>
        /// <param name="obj">video game object</param>
        /// <returns></returns>
        public int CompareTo(VideoGame obj) => string.Compare(name, obj.name);
        

        /// <summary>
        /// to string that displays all the info for a game appropriately 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str = $"Name: {name}\n";
            str += $"Platform: {platform}\n";
            str += $"Genre: {genre}\n";
            str += $"Publisher: {publisher}\n";
            str += $"NA Sales: {na_Sales}\n";
            str += $"EU Sales: {eu_Sales}\n";
            str += $"JP Sales: {jp_Sales}\n";
            str += $"Other Sales: {other_Sales}\n";
            return str;
        }// end ToString

       
    }
}
