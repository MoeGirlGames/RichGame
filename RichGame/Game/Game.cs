using System;
using System.Collections.Generic;

namespace RichGame.Game
{
    public class Game
    {
        private Map Map { get; }

        public Game(List<Player> players, List<Plot> plots)
        {
            if (players.Count > Player.MaxPlayers)
            {
                throw new ArgumentException("Players is too many to run a game.");
            }
            
            Map = new Map(players, plots);
        }
        
        
    }
}