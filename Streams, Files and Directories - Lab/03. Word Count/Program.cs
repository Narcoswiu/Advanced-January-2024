namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(wordsFilePath))
            {
                using (StreamReader readerText = new StreamReader(textFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        string[] words = reader.ReadToEnd().Split(" ");
                        int count = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            while (!readerText.EndOfStream && continue)
                            {
                                string line = readerText.ReadLine();
                                if (line.Contains(words[i]))
                                {
                                    count++;
                                }
                            }
                            writer.WriteLine($"{words[i]} - {count}");
                        }
                        
                    }
                }
            }
        }
    }
}