using Petfolio.Comunication.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petfolio.Comunication.Responses
{
    public class ResponseShortPetJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public PetType Type { get; set; }
    }
}
