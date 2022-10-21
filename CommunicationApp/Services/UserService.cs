using System;
using System.Collections.Generic;
using CommunicationApp.Data;
using CommunicationApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CommunicationApp.Services
{
    public class UserService : UserManager<Person> //ANVÄNDS DENNA?
    {
        private ApplicationDbContext _context;
        public UserService(IUserStore<Person> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<Person> passwordHasher, IEnumerable<IUserValidator<Person>> userValidators, IEnumerable<IPasswordValidator<Person>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<Person>> logger, ApplicationDbContext context) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
            _context = context;
        }
    }
}