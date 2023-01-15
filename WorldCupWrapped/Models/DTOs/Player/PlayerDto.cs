﻿using WorldCupWrapped.Models.DTOs.Team;

namespace WorldCupWrapped.Models.DTOs.Player
{
    public class PlayerDto
    {
        public Guid Id { get; set; }
        public TeamDto? Team { get; set; }
        public Guid? TeamId { get; set; }
        public string Name { get; set; }
        public string Goals { get; set; }
    }
}