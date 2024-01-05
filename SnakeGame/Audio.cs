using System;
using System.Windows.Media;

namespace SnakeGame
{
    public static class Audio
    {
        public readonly static MediaPlayer GameOver = LoadAudio("death.wav");
        private static MediaPlayer LoadAudio(string filename)
        {
            MediaPlayer player = new();
            player.Open(new Uri($"Sounds/{filename}", UriKind.Relative));

                return player;
        }
    }
}
