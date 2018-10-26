using System;
using System.Collections.Generic;
using System.Linq;
using Championship.Domain.Models;

namespace Championship.Domain.Entities
{
    public class Match
    {
        public string Name { get; set; }

        public Team firstTeam {get; set;}

        public Team secondtTeam { get; set; }

    }
}