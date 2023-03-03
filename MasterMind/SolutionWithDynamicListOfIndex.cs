namespace MasterMind
{
    public static class SolutionWithDynamicListOfIndex
    {
        public static (int positionAndColorCorrect, int colorCorrect) PlayMastermindRound(Color[] secret, Color[] guess)
        {
            List<int> visitedSecretIndexes = new List<int>();
            var score = (positionAndColorCorrect: 0, colorCorrect: 0);

            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == secret[i])
                {
                    score.positionAndColorCorrect++;
                    visitedSecretIndexes.Add(i);
                }
                else
                {
                    for (int j = 0; j < secret.Length; j++)
                    {
                        if (!visitedSecretIndexes.Contains(j))
                        {
                            if (secret[j] == guess[i])
                            {
                                score.colorCorrect++;
                                visitedSecretIndexes.Add(j);
                                break;
                            }
                        }
                    }
                }
            }

            return score;
        }
    }
}
