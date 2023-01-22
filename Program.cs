namespace Pin_Ja_Puk_Koodit
{
    
    class Program
    {
        
    public void PukKysely()
            {
            int Count_Puk = 0;
            while(true)
            {
            Console.WriteLine("Syötä PUK Koodi:");     
            string puk_input = Console.ReadLine(); 
            Count_Puk++;

            if (puk_input == "111111")
            {
            Console.WriteLine("PUK Koodi oikein! Korttisi on avattu.");
            break;
            }

            if (Count_Puk == 3)
            {
            Console.WriteLine("PUK koodi väärin, korttisi on lukittu. Soita operaattorin asiakaspalveluun!"); 
            break;
            }
            }
            }   
        static void Main(string[] args)
        {
            
            Console.WriteLine("Anna PIN Koodi, sen voi antaa 3 kertaa väärin, jonka jälkeen tarvitset PUK-koodin!"); 
            int Count_Pin = 0;
            
            while(true)
            {
            Console.WriteLine("Syötä PIN Koodi:");    
            string pin_input = Console.ReadLine();
            Count_Pin++;

            if (pin_input == "0000")
            {
                Console.WriteLine("PIN Koodi oikein! Korttisi on avattu.");
                break; 

            }
            if (Count_Pin == 3)
            {
                Console.WriteLine("Syötit PIN koodin väärin " + Count_Pin + " kertaa, tarvitset nyt PUK koodin!");
                Program AnnaPuk = new Program();
                AnnaPuk.PukKysely();
                break;
            } 
            }
            }
        }
    }
