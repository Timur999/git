using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitGuid
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public void ChangingTheLatestCommit()
        {
            // git commit --amend
            // dodaje zmiany do ostatniego komita nie tworząc nowego. 

            // Przykład uzycia:
            //1. do poprawy komit message. Gdy nie mamy nic w schowku. (nie dodawalismy zadnych zmian)
            // git commit --amend -m "updated commit message"

            //2. gdy zapomnimy dodac plik lub srednik itp.
            // git commit --amend
            // Commit message bedzie '--amend'
            // git commit --amend --no-edit
            // nie zmienimy komit message


            // git commit --amend nadpisuje poprzedni komit, który nie bedzie już dłużej widoczny.

            // git commit --amend; git pull; git push; 
            // pobieram poprzedni stan i merguje w githubie widac merga i commita w historii comitów i starego tez :/   
        }
    }
}
