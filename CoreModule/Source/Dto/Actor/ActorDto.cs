﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModule.Source.Dto.Actor
{
    public class ActorCreateDto
    {
        public ActorCreateDto(string name, string description,string?image)
        {
            Name = name;
            Description = description;
            Image = image;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }
    }
    public class ActorUpdateDto : ActorCreateDto
    {
        public int Id { get; set; }
        public ActorUpdateDto(int id, string name, string description, string? image):base(name,description,image)
        {
            Id = id;
        }
    }

}
