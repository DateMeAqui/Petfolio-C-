using Petfolio.Comunication.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petfolio.Application.UseCases.Pet.GetById
{
    public class GetPetByIdUseCase
    {
        public ResponsePetJson Execute(int id)
        {
            return new ResponsePetJson
            {
                Id = id,
                Name = "Pipoca",
                Type = Comunication.Enums.PetType.Cat,
                Birthday = new DateTime(year:2025, month:12, day:01)
            };
        }
    }
}
