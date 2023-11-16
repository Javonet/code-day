namespace Bank.Scoring
{
    public class ScoringEstimator
    {
        readonly Random rand;
        public ScoringEstimator()
        {
            rand = new Random();
        }
        public int ComputeScore(long pesel)
        {
            return rand.Next(0, 100);
        }
    }
}
