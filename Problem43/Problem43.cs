namespace Problem43
{
    // Replace Words ( Custom )
    internal class Problem43
    {

        static List<string> SplitString(string text, string delim)
        {

            List<string> lWords = new List<string>();

            string sWord = "";
            short pos = (short)text.IndexOf(delim);

            while (pos != -1)
            {

                sWord = text.Substring(0, pos);

                if (sWord != "")
                {
                    lWords.Add(sWord);
                }

                text = text.Substring(pos + delim.Length);

                pos = (short)text.IndexOf(delim);

            }

            if (text != "")
            {

                lWords.Add(text);

            }

            return lWords;

        }

        static string JoinString(List<string> lWords, string delim)
        {

            string text = "";

            foreach (string word in lWords)
            {
                text += word + delim;
            }

            text = text.Substring(0, text.Length - delim.Length);

            return text;

        }

        static string LowerAllString(string text)
        {

            char[] charArray = text.ToCharArray();

            for (short i = 0; i < charArray.Length; i++)
            {

                charArray[i] = char.ToLower(charArray[i]);

            }

            return new string(charArray);

        }

        static string ReplaceWordInStringUsingSplit(string text, string wordToReplace, string replaceTo, bool matchCase = true)
        {

            string text2 = "";

            List<string> lWords = SplitString(text, " ");

            for (short i = 0; i < lWords.Count; i++)
            {

                if (matchCase)
                {

                    if (lWords[i] == wordToReplace)
                    {
                        lWords[i] = replaceTo;
                    }

                }
                else
                {

                    if (LowerAllString(lWords[i]) == LowerAllString(wordToReplace))
                    {
                        lWords[i] = replaceTo;
                    }

                }

            }

            text2 = JoinString(lWords, " ");

            return text2;

        }

        static void Main(string[] args)
        {

            string s1 = "Welcome to Egypt , Egypt is a nice country";
            string wordToReplace = "egypt";
            string replaceTo = "USA";

            Console.WriteLine("\nOriginal String:\n" + s1);

            Console.WriteLine("\nReplace With Match Case : ");

            Console.WriteLine(ReplaceWordInStringUsingSplit(s1, wordToReplace, replaceTo));

            Console.WriteLine("\nReplace With don't Match Case : ");

            Console.WriteLine(ReplaceWordInStringUsingSplit(s1, wordToReplace, replaceTo, false));

        }
    }
}