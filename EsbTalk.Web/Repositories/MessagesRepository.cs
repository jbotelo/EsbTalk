using EsbTalk.Web.Data;
using EsbTalk.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsbTalk.Web.Repositories
{
    public class MessagesRepository : IMessagesRepository
    {
        private readonly ApplicationDbContext _db;

        public MessagesRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Message> CreateAsync(Message m)
        {
            await _db.Messages.AddAsync(m);
            await _db.SaveChangesAsync();
            return m;
        }

        public IEnumerable<Message> RetrieveMessagesToShow()
        {
            return _db.Messages.ToList().TakeLast<Message>(50);
        }
    }
}
