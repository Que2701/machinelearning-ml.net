using System;
using MyMLAppML.Model;

namespace MyMLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput();
            input.SentimentText = "this is rude";
            // Load model and predict output of sample data
            ModelOutput modelOutput = ConsumeModel.Predict(input);
            Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {modelOutput.Prediction}");

            Console.WriteLine("ML.Net");
        }
    }
}
