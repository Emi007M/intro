using System.Net;

using static System.Net.WebRequestMethods;

namespace IntroOne
{
    class T6
    {
        public T6()
        {
            //var resultIndexes = new List<int>() {123,423,323};
            ////resultIndexes.Add(123);
            ////resultIndexes.Add(423);
            ////resultIndexes.Add(323);

            //resultIndexes.Sort();

            //for(int i = 0; i < resultIndexes.Count; i++)
            //{
            //    Console.WriteLine(resultIndexes[i]);
            //}


            Console.WriteLine("---helo");
            var url = "https://wolnelektury.pl/media/book/txt/pan-tadeusz.txt";
            string wholeText = GetTextFromUrlAsync(url).Result;
            string textSample = wholeText.Substring(0, 300);

            Console.WriteLine(textSample);

            Console.WriteLine("---");


            var searchTxt = "Księga";

            //FindFirstOccurenceOfFirstSignFromSearchText(wholeText, searchTxt);

            Console.WriteLine("---");

            //FindAllOccurencesOfFirstSignFromSearchText(wholeText, searchTxt);

            Console.WriteLine("---");

           // FindAllOccurencesOfSearchText(wholeText, searchTxt);


            var foundIndexes = FindAllPositionsOfBookTitles(wholeText);

            for (int i = 0; i < foundIndexes.Count; i++)
            {
                Console.WriteLine(foundIndexes[i]);

                string title = GetBookTitleByIndex(foundIndexes[i]);
                string subtitle = GetBookSubtitleByIndex(foundIndexes[i]);

                Console.WriteLine(subtitle);
            }


        }

        private string GetBookTitleByIndex(int startIndex)
        {
            //todo
            //zwraca np "Umizgi" dla księgi trzeciej
            var result = "";

            return result;
        }

        private string GetBookSubtitleByIndex(int startIndex)
        {
            //todo
            //zwraca cały pierwszy paragraf pod tytułem księgi, czyli np "Wyprawa Hrabiego..." dla księgi trzeciej
            var result = "";

            return result;
        }

        public static async Task<string> GetTextFromUrlAsync(string url)
        {
            var uri = new Uri(url);
            using HttpClient client = new HttpClient();
            return await client.GetStringAsync(uri);
        }

        private static void FindFirstOccurenceOfFirstSignFromSearchText(string text, string searchTxt)
        {
            var searchSign = searchTxt[0]; //pierwszy znak (na pozycji o indeksie 0) z searchTxt - '3'
            var foundIndex = text.IndexOf(searchSign); //pozycja pierwszego wystąpienia szukanego znaku w tekście text

            Console.WriteLine($"Szukany znak {searchSign} znaleziony na pozycji {foundIndex}");
        }

        private static void FindAllOccurencesOfFirstSignFromSearchText(string text, string searchTxt)
        {
            var searchSign = searchTxt[0];

            for(var i=0; i<text.Length; i++) //wykonań pętli MAX tyle ile znaków w tekście
            {
                var foundIndex = text.IndexOf(searchSign, i); //zaczynając od pozycji 'i' znajdź pierwsze wystąpienie szukanego znaku

                if (foundIndex != -1) //wyświetlaj pozycję tylko jeśli została znaleziona
                {
                    i = foundIndex; //zwiększ 'i' do ostatniej znalezionej pozycji aby ominąć te same wyniki
                    Console.WriteLine($"Szukany znak {searchSign} znaleziony na pozycji {foundIndex}");
                } else
                {
                    //jeśli nie znaleziono następnej pozycji, to zakończ pętlę
                    i = text.Length;
                }
            }
        }

        private static void FindAllOccurencesOfSearchText(string text, string searchTxt)
        {
            var searchSign = searchTxt[0];

            for (var i = 0; i < text.Length; i++) //wykonań pętli MAX tyle ile znaków w tekście
            {
                var foundIndex = text.IndexOf(searchSign, i); //zaczynając od pozycji 'i' znajdź pierwsze wystąpienie szukanego znaku

                if (foundIndex != -1) //wyświetlaj pozycję tylko jeśli została znaleziona
                {
                    i = foundIndex; //zwiększ 'i' do ostatniej znalezionej pozycji aby ominąć te same wyniki
                    //Console.WriteLine($"Szukany znak {searchSign} znaleziony na pozycji {foundIndex}");

                    //tu mamy znaleziony pierwszy znak z searchTxt
                    //musimy sprawdzić czy jest to początek całego searchTxt
                    var textSample = text.Substring(foundIndex, searchTxt.Length);

                    if(textSample == searchTxt)
                    {
                        Console.WriteLine($"Znaleziono tekst '{searchTxt}' na pozycji {foundIndex}");
                        var result = text.Substring(foundIndex, searchTxt.Length + 20);
                        Console.WriteLine(result);

                        var indexOfNewLine = result.IndexOf("\n");
                        if (indexOfNewLine != -1)
                        {
                            Console.WriteLine("TO jest tytuł księgi !");
                        }
                        else {
                            Console.WriteLine("PUDŁO");
                        }
                    }

                }
                else
                {
                    //jeśli nie znaleziono następnej pozycji, to zakończ pętlę
                    i = text.Length;
                }
            }
        }


        private static List<int> FindAllPositionsOfBookTitles(string text)
        {
            var searchTxt = "Księga";

            var resultIndexes = new List<int>();
           


            for (var i = 0; i < text.Length; i++) //wykonań pętli MAX tyle ile znaków w tekście
            {
                var foundIndex = text.IndexOf(searchTxt, i); //zaczynając od pozycji 'i' znajdź pierwsze wystąpienie szukanego znaku

                if (foundIndex != -1) //wyświetlaj pozycję tylko jeśli została znaleziona
                {
                    i = foundIndex; //zwiększ 'i' do ostatniej znalezionej pozycji aby ominąć te same wyniki

                        Console.WriteLine($"Znaleziono tekst '{searchTxt}' na pozycji {foundIndex}");
                        var result = text.Substring(foundIndex, searchTxt.Length + 20);
                        Console.WriteLine(result);

                        var indexOfNewLine = result.IndexOf("\n");
                        if (indexOfNewLine != -1)
                        {
                            Console.WriteLine("TO jest tytuł księgi !");
                            resultIndexes.Add(foundIndex);
                        }
                        else
                        {
                            Console.WriteLine("PUDŁO");
                        }
                    

                }
                else
                {
                    //jeśli nie znaleziono następnej pozycji, to zakończ pętlę
                    i = text.Length;
                }
            }

            return resultIndexes;
        }



    }
}


