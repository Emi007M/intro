namespace IntroOne
{
    class T5_Exercises
    {
        public T5_Exercises()
        {
            var text = "123346433743342";
            var searchTxt = "334";

           // FindFirstOccurenceOfFirstSignFromSearchText(text, searchTxt);

            Console.WriteLine("---");

            //FindAllOccurencesOfFirstSignFromSearchText(text, searchTxt);

            Console.WriteLine("---");

            FindAllOccurencesOfSearchText(text, searchTxt);

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
                    Console.WriteLine($"Szukany znak {searchSign} znaleziony na pozycji {foundIndex}");

                    Console.WriteLine($"znaleziony indeks={foundIndex} dla znaku {searchSign}");

                    //tu mamy znaleziony pierwszy znak z searchTxt
                    //musimy sprawdzić czy jest to początek całego searchTxt
                    var textSample = text.Substring(foundIndex, searchTxt.Length);

                    Console.WriteLine($"znaleziony substring={textSample} do porównywania z {searchTxt}");

                    if (textSample == searchTxt)
                    {
                        Console.WriteLine($"Znaleziono tekst '{searchTxt}' na pozycji {foundIndex}");
                    }
                }
                else
                {
                    //jeśli nie znaleziono następnej pozycji, to zakończ pętlę
                    i = text.Length;
                }
            }
        }


    }
}


