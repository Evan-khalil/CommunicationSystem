using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunicationApp.Data;
using CommunicationApp.Models;

namespace CommunicationApp.Repository
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext identityContext) : base(identityContext)
        {
        }
    }
}