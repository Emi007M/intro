namespace IntroOne
{
    class T4
    {
        public T4()
        {

            // printing different triangles

            int x = 4;
            char sign = '#';


            /// square triangle 
            /// 
            /// #
            /// ##
            /// ###
            /// ####
            /// 
            PrintSquareTriangle(x, sign);

            Console.WriteLine();


            /// reverse square triangle 
            /// 
            ///    #
            ///   ##
            ///  ###
            /// ####
            /// 


            /// equilateral triangle (given h)
            /// 
            ///    #
            ///   ###
            ///  #####
            /// #######
            /// 


            /// equilateral triangle border (given h)
            /// 
            ///    #
            ///   # #
            ///  #   #
            /// #######
            /// 

        }

        private static void PrintSquareTriangle(int x, char sign)
        {
            

            for (int linia = 0; linia < x; linia++)
            {
                for (int i = 0; i <= linia; i++)
                {
                    Console.Write(sign);
                }
                Console.WriteLine();

            }
        }

    }
}


