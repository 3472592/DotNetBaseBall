using System;
using System.Collections.ObjectModel;
namespace Baseball
{
    internal class Fan : Fan_Pitcher
    {
        public ObservableCollection<string> FanSays = new();

        public Fan(Ball ball)
        {
            ball.BallInPlay += new(ball_BallInPlay);
        }

        #pragma warning disable IDE1006 // Naming Styles
        private void ball_BallInPlay(object? sender, EventArgs e)
        {
            _pitchNum++;

            if (e is BallEventArgs)
            {
                BallEventArgs? ballEventArgs = e as BallEventArgs;

                if ((ballEventArgs?.Distance < 95) && (ballEventArgs.Trajectory < 60))
                    FanSays.Add("Pitch #" + _pitchNum
                         + ": Home run! I'm going for the ball!");
                else
                    FanSays.Add("Pitch #" + _pitchNum + ": Woo-hoo! Yeah!");
            }
        }
    }
}