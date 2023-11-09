namespace IntroOne
{
    class PrzepisNaBabke
    {

        public static int IloscMakiWG = 500;  //zmienna jest globalna dla wsyzstkich babek 

        public int IloscCukruWG = 5;  //zmienna jest lokalna - może być inna dla każdej z babek


        public PrzepisNaBabke()
        {

        }
        public void ZmienIloscMaki(int maka)
        {
            IloscMakiWG = maka;
            Console.WriteLine("zmieniono ilosc mąki potrzebnego na babkę na " + IloscMakiWG);
        }

        public void IleMakiPotrzeba()
        {
            Console.WriteLine("na babkę potrzeba " + IloscMakiWG + "g mąki");
        }

        public void ZmienIloscCukru(int cukier)
        {
            IloscCukruWG = cukier;
            Console.WriteLine("zmieniono ilość cukru potrzebnego na babkę na " + IloscCukruWG);
        }

        public void IleCukruPotrzeba()
        {
            Console.WriteLine("na babkę potrzeba " + IloscCukruWG + "g cukru");
        }

    }
}
