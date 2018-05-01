using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SporkBot.Modules
{
    public class Hangman : ModuleBase<SocketCommandContext>
    {
        [Command("hangman")]
        public async Task HangmanAsync()
        {
            string[] words = new string[3];
            //intializing the words array with different words the player might want to play from
            words[0] = "Hello Word";
            words[1] = "Raginkorosu";
            words[2] = "Okurimono";
            //prints this to the console on discord
            await ReplyAsync("Welcome to the hangman game!");
            string playString;
            Random rnd = new Random();
            int randNumb = rnd.Next(1, 4);
            if (randNumb == 1)
            {
                playString = words[0];
            } else if (randNumb == 2)
            {
                playString = words[1];
            }
            else
            {
                playString = words[2];
            }
            await ReplyAsync("The word is: "  + playString);
        }
    }
}
