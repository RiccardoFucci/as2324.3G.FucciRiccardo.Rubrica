namespace es_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[100];
            string[] cognome = new string[100];
            string[] email = new string[100];
            string[] nickname = new string[100];
            int [] annoNascita = new int[100];
            int [] simpatia = new int[100];
            int scelta =Convert.ToInt32(Console.ReadLine());
            string NomeP;
            string CognomeP;
            int i = 0;
            string searchNickname;
            do
            {
                Console.WriteLine("che operazione vuoi svolgere?");
                Console.WriteLine("1.inserimento completo di un nominativo");
                Console.WriteLine("2. elenco dei nominativi inseriti");
                Console.WriteLine("3. ricerca di un nominativo per nickname");
                Console.WriteLine("4. fine del programma");
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("inserire il nome");
                        nome[i] = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("inserire il cognome");
                        cognome[i] = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("inserire l'email");
                        email[i] = Convert.ToString(Console.ReadLine());
                        Console.WriteLine($"inserire il nickname a {nome[i]} {cognome[i]}");
                        nickname[i] = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("inserire l'anno di nascita ");
                        annoNascita[i] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("inserire la simpatia");
                        simpatia [i] = Convert.ToInt32(Console.ReadLine());
                        i++;
                        break;
                        case 2:
                        for (int j = 0; j < 100; j++)
                        {
                            Console.WriteLine($"nome{nome}"); Console.WriteLine($"cognome{cognome}"); Console.WriteLine($"email{email}"); Console.WriteLine($"nickname{nickname}"); Console.WriteLine($"anno nascita{annoNascita}"); Console.WriteLine($"simpatia{simpatia}");
                        }
                        break;
                         
                        case 3:
                        Console.WriteLine("inserire il nickname da cercare");
                        searchNickname=Convert.ToString(Console.ReadLine());
                        for(int k = 0;k < 100; k++)
                        {
                            if (searchNickname == nickname[k])
                            {
                                Console.WriteLine($"il nominativo trovato corrisponde a{k}");
                                Console.WriteLine($"{nome[k]}      {cognome[k]}        {email[k]}         {annoNascita[k]}          {simpatia[k]}");
                                
                            }
                            else
                            {
                                Console.WriteLine("non è stata trovata nessuna corrispondenza");
                            }
                           
                        }
                        break;

                }  
            }while (scelta!=0);

        }
    }
}
