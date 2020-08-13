using RichGame.Enumerates;

namespace RichGame.Game
{
    public class Plot
    {
        private PlotType Type { get; }
        
        public Plot(PlotType type)
        {
            Type = type;
        }
    }
}