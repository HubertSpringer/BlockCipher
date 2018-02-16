using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Szyfrator
{
    class Nihilist
    {
       public String encrypt(String keyword, String message,Options options)
        {
            int [] converted_keyword = convert_keyword(keyword,options);
            char[] in_msg = convert_message(message,options);
            String s = String.Join("", in_msg);
            s = Regex.Replace(s, System.Environment.NewLine, "");

            int k = converted_keyword.Length;

            int licznik = 0;
            bool flaga = true;

            char[,] tablica = new char[k,k];

            for(int i = 0; i < k; i++)
            {
                for (int l = 0; l < k; l++)
                {
                    if (licznik < in_msg.Length) {
                        tablica[i, l] = in_msg[licznik];                
                    }
                    else
                    {
                        tablica[i, l] = options.get_cryptogram_replace().ToCharArray()[0];
                        flaga = false;
                    }
                    licznik++;
                }
            }

            char[] wynik = new char[licznik];

            for (int i = 0; i < k; i++)
            {
                for (int l = 0; l < k; l++)
                {
                    wynik[(((converted_keyword[i]-1)*k)+(converted_keyword[l]))-1]= tablica[i, l];

                }
            }

            if (flaga)
            {
                return string.Join("", wynik) + encrypt(keyword,s.Substring(licznik), options);
            }
            
         
            return     string.Join("", wynik); 

        }

       public String decrypt(String keyword,String message, Options options)
        {
            int[] converted_keyword = convert_keyword(keyword, options);
            char[] in_msg = convert_message(message, options);
            String s = Regex.Replace(message, System.Environment.NewLine, "");
            int k = converted_keyword.Length;
            

            char[] wynik = new char[k*k];
            int index = 0;
            bool flaga = true;

            for (int i = 0; i < k*k; i++)
            {
                index = (k * (converted_keyword[(int)(i / k)] - 1) + converted_keyword[i % k] - 1);
                if (index < in_msg.Length)
                {
                    wynik[i] = in_msg[index];
                }
                else
                {
                    wynik[i] = options.get_cryptogram_replace().ToCharArray()[0];
                    flaga = false;
                }
            }

            if (flaga)
            {
                return string.Join("", wynik) + decrypt(keyword, s.Substring((k*k)), options);
            }

            return string.Join("", wynik);
        }

        private int[] convert_keyword (String keyword,Options options)
        {
            
            if (options.get_keyword_white() && options.get_keyword_capital_letters())
            {
               keyword=keyword.Replace(" ", "").Replace("\n", "").ToLower();
            }
            else if (options.get_keyword_white())
            {
               keyword=keyword.Replace(" ", "").Replace("\r\n", "");
            }
            else if (options.get_keyword_capital_letters())
            {
               keyword= keyword.ToLower();
            }

            char[] not_orderly = String.Copy(keyword).ToCharArray();
            char[] orderly_keyword = String.Copy(keyword).ToCharArray(); ;
            Array.Sort(orderly_keyword);

            int lenght = orderly_keyword.Length; //dlugosc

            Dictionary<int, char> dictionary = new Dictionary<int, char>();

            for (int i = 1; i <= lenght; i++)
            {
                dictionary.Add(i, orderly_keyword[i - 1]);
            }


            int[] converted_keyword = new int[lenght]; 

            for(int i = 0; i< lenght; i++)
            {
                foreach (KeyValuePair<int,char> x in dictionary)
                {
                     if (not_orderly[i] == x.Value )
                        {
                            converted_keyword[i] = x.Key;
                            dictionary.Remove(x.Key);
                            break;
                        }
                }  
            }
         
            return converted_keyword;
        }

        private char[] convert_message (String message, Options options)
        {
            char[] in_msg;

            if (!options.get_message_white())
            {
                message = Regex.Replace(message, System.Environment.NewLine ,"");
            }

            if (options.get_message_white() && options.get_message_capital_letters())
            {
                in_msg = message.Replace(" ", "").Replace("\r", "").Replace("\n", "").ToLower().ToCharArray();
                
            }
            else if (options.get_message_white())
            {
                in_msg = message.Replace(" ", "").Replace("\r", "").Replace("\r", "").ToCharArray();
            }
            else if (options.get_message_capital_letters())
            {
                in_msg = message.ToLower().ToCharArray();
            }
            else
            {
                in_msg = message.ToCharArray();
            }

            return in_msg;
        }

        private Boolean sprawdz (int[] tablica, int liczba)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] == liczba) return true;
                
            }
            return false;
        }
        
    }
}
