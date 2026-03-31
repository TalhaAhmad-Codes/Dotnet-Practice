namespace AIApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Load sample data
            var sampleData = new ClassifierModel.ModelInput()
            {
                Col0 = @"I love you.",
            };

            // Load model and predict output
            var result = ClassifierModel.Predict(sampleData);

            // Display the result
            Console.WriteLine($"Text:\t\t{sampleData.Col0}");
            var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
            Console.WriteLine($"Sentiment:\t{sentiment}");
            Console.WriteLine($"\nPossitive:\t{result.Score[0] * 100}%");
            Console.WriteLine($"Negative:\t{result.Score[1] * 100}%");
        }
    }
}
