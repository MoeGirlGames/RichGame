using System;
using System.Collections.Generic;
using RichGame.Enumerates;

namespace RichGame.Game
{
    public class Map
    {
        private List<Player> Players = new List<Player>(Player.MaxPlayers);

        private List<Plot> Plots = new List<Plot>();
        
        public Map(List<Player> players, List<Plot> plots)
        {
            for (int i = 0; i < players.Count; i++)
            {
                Players[i] = players[i];
            }
            
            Plots.AddRange(plots);
        }

        public void Move(PlayersOrder playerOrder, int steps)
        {
            
        }
    }
}