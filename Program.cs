using System;
using Teams;

//Реализовать программу “Строительство дома”

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team(5);

            team.Start();
        }
    }
}
