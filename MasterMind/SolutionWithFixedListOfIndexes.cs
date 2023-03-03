namespace MasterMind
{
    public static class SolutionWithFixedListOfIndexes
    {
        public static (int positionAndColorCorrect, int colorCorrect) PlayMastermindRound(Color[] secret, Color[] guess)
        {
            var visitedSecretIndexes = Enumerable.Range(0, secret.Length).Select(x => false).ToList();
            var score = (positionAndColorCorrect: 0, colorCorrect: 0);

            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == secret[i])
                {
                    score.positionAndColorCorrect++;
                    visitedSecretIndexes[i] = true;
                }
                else
                {
                    for (int j = 0; j < secret.Length; j++)
                    {
                        if (!visitedSecretIndexes[j])
                        {
                            if (secret[j] == guess[i])
                            {
                                score.colorCorrect++;
                                visitedSecretIndexes[j] = true;
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
