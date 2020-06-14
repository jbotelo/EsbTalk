using EsbTalk.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsbTalk.Web.Repositories
{
    public interface IMessagesRepository
    {
        Task<Message> CreateAsync(Message m);

        IEnumerable<Message> RetrieveMessagesToShow();
    }
}
