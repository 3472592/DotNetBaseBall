using System.Collections.ObjectModel;
namespace Baseball
{
    internal class BaseballSimulator
    {
        private readonly Ball _ball = new();
        private readonly Pitcher _pitcher;
        private readonly Fan _fan;

        public ObservableCollection<string> FanSays
        {
            get
            {
                return _fan.FanSays;
            }
        }

        public ObservableCollection<string> PitcherSays
        {
            get
            {
                return _pitcher.PitcherSays;
            }
        }

        public int Trajectory { get; set; }
        public int Distance { get; set; }

        public BaseballSimulator()
        {
            _pitcher = new Pitcher(_ball);
            _fan = new Fan(_ball);
        }

        public void PlayBall()
        {
            BallEventArgs? ballEventArgs = new(Trajectory, Distance);
            _ball.OnBallInPlay(ballEventArgs);
        }
    }
}