using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Dott.Nets_RPG.Models;

namespace Dott.Nets_RPG.Services.CharacterService
{
    public interface ICharacterService
    {
       Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();

       Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
       
       Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
     

    }
}