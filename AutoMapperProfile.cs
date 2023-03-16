using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dott.Nets_RPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto , Character>();
        }
    }
}