using System;
using System.Collections.ObjectModel;
namespace Baseball
{
    internal class Pitcher : Fan_Pitcher
    {
        public ObservableCollection<string> PitcherSays = new();

        public Pitcher(Ball ball)
        {
            ball.BallInPlay += ball_BallInPlay;
        }

        #pragma warning disable IDE1006 // Naming Styles
        private void ball_BallInPlay(object? sender, EventArgs e)
        {
            _pitchNum++;
            if (e is BallEventArgs)
            {
                BallEventArgs? ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs?.Distance < 95) && (ballEventArgs.Trajectory < 60))
                    CatchBall();
                else
                    CoverFirstBase();
            }
        }

        private void CatchBall()
        {
            PitcherSays.Add("Pitch #" + _pitchNum + ": I caught the ball");
        }

        private void CoverFirstBase()
        {
            PitcherSays.Add("Pitch #" + _pitchNum + ": I covered first base");
        }
    }
}
