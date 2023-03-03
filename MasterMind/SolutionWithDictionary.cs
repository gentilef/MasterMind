namespace MasterMind {
    public static class SolutionWithDictionary {
        public static (int positionAndColorCorrect, int colorCorrect) PlayMastermindRound(Color[] secret, Color[] guess) {
            var secretColorIndex = PopulateColorIndex(secret);
            var guessColorIndex = PopulateColorIndex(guess);

            var score = (positionAndColorCorrect: 0, colorCorrect: 0);

            foreach (var colorGuess in guessColorIndex) {
                var colorGuessed = colorGuess.Key;
                if (secretColorIndex.ContainsKey(colorGuessed)) {
                    var (positionAndColorCorrect, colorCorrect) = ComputeScorePerColor(secretColorIndex[colorGuessed], guessColorIndex[colorGuessed]);
                    score.positionAndColorCorrect += positionAndColorCorrect;
                    score.colorCorrect += colorCorrect;
                }
            }

            return score;
        }

        private static Dictionary<Color, List<int>> PopulateColorIndex(IReadOnlyList<Color> colorSequence) {
            var colorIndex = new Dictionary<Color, List<int>>();

            for (int i = 0; i < colorSequence.Count; i++) {
                var color = colorSequence[i];
                if (!colorIndex.TryAdd(color, new List<int> { i })) {
                    colorIndex[color].Add(i);
                }
            }

            return colorIndex;
        }

        // words too long!
        private static (int positionAndColorCorrect, int colorCorrect) ComputeScorePerColor(IReadOnlyCollection<int> secretIndexes, IReadOnlyCollection<int> guessIndexes) {
            var correctPositionAndColor = guessIndexes.Intersect(secretIndexes).Count();

            var secretColorPositionNotGuessed = secretIndexes.Count - correctPositionAndColor;
            var guessColorPositionNotGuessed = guessIndexes.Count - correctPositionAndColor;

            return (correctPositionAndColor, Math.Min(secretColorPositionNotGuessed, guessColorPositionNotGuessed));

        }
    }
}
