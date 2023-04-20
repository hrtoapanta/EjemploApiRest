using System;

namespace EjemploApiRest.Entities
{
    public class FootballTeam: Entity
    {
        public string Name { get; set; }
        public int Score { get; set; }  
        public string Manager { get; set; }
    }
}
