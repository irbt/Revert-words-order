//Given a string, write a method that returns new string with reverted words order. Pay attention to the punctuation at the end of the sentence (period).
using System.Text;
using System;

namespace Program{
    class Revert{
        public static void Main(){
            static void RevertWordsOrder(string s){

                    //List<string> listPhrases = new List<string>() ;
                    string sep = " ";
                    string [] tableauPhrases = s.Split(sep);
                    int len = tableauPhrases.Length;
                    //string sPartial = s;


                for(int i= len-1; i >= 0 ; i--){
                    Console.Write(tableauPhrases[i] + sep);
                    
                }
                Console.WriteLine();
                    
                
            }
        RevertWordsOrder("John Doe. MAchin. bk"); //→ "Doe John."
        RevertWordsOrder("A, B. C");// → "C B. A,"
        }
    }
}