namespace IntroOne
{
    class T3
    {
        public T3()
        {
            // creating instances of class PrzepisNaBabke
            BakeCake();

            Console.WriteLine();


            // printing different rectangles

            int x = 6, y = 4;
            char sign = '#';

            /// rectangle 
            ///
            /// ###
            /// ###
            /// ###
            PrintRectangle(x, y, sign);

            Console.WriteLine();


            /// rectangle border
            ///
            /// ###
            /// # #
            /// # #
            /// ###
            PrintRectangleBorder(x, y, sign);

            Console.WriteLine();

        }

        private static void PrintRectangleBorder(int x, int y, char sign)
        {
            //top
            for (int j = 0; j < x; j++)
            {
                Console.Write(sign);
            }
            Console.WriteLine();


            //center
            for (int i = 0; i < y - 2; i++)
            {
                Console.Write(sign);
                for (int j = 0; j < x - 2; j++)
                {
                    Console.Write('_');
                }
                Console.WriteLine(sign);
            }

            //bottom
            for (int j = 0; j < x; j++)
            {
                Console.Write(sign);
            }
            Console.WriteLine();
        }

        private static void PrintRectangle(int x, int y, char sign)
        {
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(sign);
                }
                Console.WriteLine();
            }
        }

        private static void BakeCake()
        {
            PrzepisNaBabke babka1 = new PrzepisNaBabke();

            PrzepisNaBabke babka2 = new PrzepisNaBabke();

            // using local parameter (variable)
            babka1.IleCukruPotrzeba(); //5
            babka2.IleCukruPotrzeba(); //5

            babka1.ZmienIloscCukru(10);
            babka1.IleCukruPotrzeba(); //10
            babka2.IleCukruPotrzeba(); //5

            Console.WriteLine();

            // using static (global) parameter
            babka1.IleMakiPotrzeba(); //500
            babka2.IleMakiPotrzeba(); //500

            babka1.ZmienIloscMaki(450);
            babka1.IleMakiPotrzeba(); //450
            babka2.IleMakiPotrzeba(); //450
        }
    }
}


