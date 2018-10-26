using System;


namespace Championship.Domain.Entities
{
    public class Team
    {
        public Team()
        {
            this.TeamId = Guid.NewGuid();
        }

        public Guid TeamId { get; set; }

        public string Name { get; set; }

        public int Score { get; set; }

        public int KeyPosition { get; set; }

    }
}