using System.Linq;
using System.Threading.Tasks;
using DevDrillAPI.Dto;
using DevDrillAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace DevDrillAPI.Services
{
    public class ForumService
    {
        private readonly DevDrillDbContext dbContext;

        public ForumService(DevDrillDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<DiscussionGroupDto>> GetDiscussionGroup()
        {
            return await dbContext.DiscussionGroups
                .Select(e => new DiscussionGroupDto()
                {
                    Name = e.Name,
                    PhotoUrl = e.PhotoUrl,
                    DiscussionGroupId = e.DiscussionGroupId,
                    Discussions = e.Discussions.Select(d => new DiscussionDto()
                    {
                        Name = d.Name,
                        DiscussionId = d.DiscussionId
                    }).ToList()
                })
                .ToListAsync();
        }

        public async Task<List<ThreadDto>> GetThreads(int discussionId)
        {
            return await dbContext.Threads
                .Where(e => e.DiscussionId == discussionId)
                .Include(e => e.User)
                .Include(e => e.Replies)
                .Select(e => new ThreadDto()
                {
                    Topic = e.Topic,
                    ThreadId = e.ThreadId,
                    Upvote = e.Upvote,
                    Author = e.User.Name,
                    ReplyCount = e.Replies.Count
                })
                .ToListAsync();
        }

        public async Task<List<ReplyDto>> GetReplies(int threadId)
        {
            return await dbContext.Replies
                .Where(e => e.ThreadId == threadId)
                .Include(e => e.User)
                .Include(e => e.Thread)
                .Select(e => new ReplyDto()
                {
                    Detail = e.Detail,
                    InsertDate = e.InsertDate,
                    ReplyId = e.ReplyId,
                    Upvote = e.Upvote,
                    User = new UserDto()
                    {
                        UserId = e.User.UserId,
                        IsInstructor = e.User.Instructor != null,
                        Name = e.User.Name
                    },
                    Topic = e.Thread.Topic
                })
                .ToListAsync();
        }
    }
}