using CQRSReadApplication.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSReadApplication
{
    public class Contexto : IContexto
    {
        public IPersonRepository People { get; set; }
        public Contexto(IPersonRepository personRepository)
        {
            People = personRepository;
        }


    }
}
