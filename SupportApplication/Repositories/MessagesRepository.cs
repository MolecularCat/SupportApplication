using Microsoft.Extensions.Configuration;
using SupportApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportApplication.Repositories
{
    public class MessagesRepository
    {
        private readonly IConfiguration _configration;
        private readonly AppDbContext context;

        public MessagesRepository(IConfiguration configuration, AppDbContext context)
        {
            _configration = configuration;
            this.context = context;
        }

        public List<Messages> GetAllMessages()
        {
            var messages = context.Messages.ToList();
            return messages;
        }
    }
}
