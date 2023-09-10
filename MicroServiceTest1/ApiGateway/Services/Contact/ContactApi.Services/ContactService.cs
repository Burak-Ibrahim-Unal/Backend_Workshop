﻿using ContactApi.Infrastructure;
using ContactApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApi.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactById(int id)
        {
            return new ContactDTO 
            {
                Id = id,
                LastName = "Unal",
                FirstName = "Burak Ibrahim",
            };
        }
    }
}