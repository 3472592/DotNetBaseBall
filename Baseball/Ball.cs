using System;
namespace Baseball
{
    internal class Ball
    {
        public event EventHandler? BallInPlay;

        public void OnBallInPlay(BallEventArgs e)
        {
            EventHandler? ballInPlay = BallInPlay;
            if (ballInPlay != null)
                BallInPlay?.Invoke(this, e);
        }
    }
}