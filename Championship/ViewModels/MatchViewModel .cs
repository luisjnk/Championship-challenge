using Championship.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Championship.ViewModels
{
    public class MatchViewModel
    {
        public string Name { get; set; }

        public TeamViewModel firstTeam { get; set; }

        public TeamViewModel secondTeam { get; set; }

    }

}