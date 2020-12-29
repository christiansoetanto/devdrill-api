using System;
using System.Linq;
using System.Threading.Tasks;
using DevDrillAPI.Dto;
using DevDrillAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


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

        public async Task<DiscussionDto> GetDiscussion(int discussionId)
        {
            return await dbContext.Discussions
                .Where(x => x.DiscussionId == discussionId)
                .Include(e => e.DiscussionGroup)
                .Select(e => new DiscussionDto
                {
                    DiscussionId = e.DiscussionId,
                    Name = e.Name,
                    Threads = null,
                    DiscussionGroup = new DiscussionGroupDto
                    {
                        DiscussionGroupId = e.DiscussionGroup.DiscussionGroupId,
                        Name = e.DiscussionGroup.Name,
                        PhotoUrl = e.DiscussionGroup.PhotoUrl
                    },
                    DiscussionGroupId = e.DiscussionGroupId
                })
                .AsNoTracking()
                .FirstOrDefaultAsync();
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
                    ReplyCount = e.Replies.Count,
                    DiscussionId = discussionId,
                    Detail = e.Detail,
                    InsertDate = e.InsertDate
                })
                .ToListAsync();
        }
        public async Task<ThreadDto> GetThread(int threadId)
        {
            return await dbContext.Threads
                .Where(x => x.ThreadId == threadId)
                .Include(e => e.User)
                .Include(e => e.Replies)
                .Select(e => new ThreadDto
                {
                    Topic = e.Topic,
                    ThreadId = e.ThreadId,
                    Upvote = e.Upvote,
                    Author = e.User.Name,
                    ReplyCount = e.Replies.Count,
                    DiscussionId = e.DiscussionId,
                    Detail = e.Detail,
                    InsertDate = e.InsertDate,
                    IsInstructor = e.User.IsInstructor
                })
                .AsNoTracking()
                .FirstOrDefaultAsync();
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
                    Topic = e.Thread.Topic,
                    ThreadId = e.ThreadId
                })
                .ToListAsync();
        }

        public async Task InsertThread(int userId, int discussionId, string topic, string detail)
        {
            var add = await dbContext.Threads.AddAsync(new Thread()
            {
                Topic = topic,
                Upvote = 0,
                DiscussionId = discussionId,
                InsertDate = DateTime.Now,
                Detail = detail,
                UserId = userId
            });

            await dbContext.Replies.AddAsync(new Reply()
            {
                Detail = detail,
                Upvote = 0,
                InsertDate = add.Entity.InsertDate,
                ThreadId = add.Entity.ThreadId,
                UserId = userId
            });

            await dbContext.SaveChangesAsync();
        }
        public async Task UpdateThread(int threadId, string topic, string detail)
        {
            Thread x = await dbContext.Threads.FindAsync(threadId);
            if (x == null) throw new KeyNotFoundException();
            x.Topic = topic;
            x.Detail = detail;
            await dbContext.SaveChangesAsync();
        }

        public async Task InsertReply(int userId, int threadId, string detail)
        {
            await dbContext.Replies.AddAsync(new Reply()
            {
                Detail = detail,
                Upvote = 0,
                InsertDate = DateTime.Now,
                ThreadId = threadId,
                UserId = userId
            });

            await dbContext.SaveChangesAsync();
        }
        public async Task UpdateReply(int replyId, string detail)
        {
            Reply x = await dbContext.Replies.FindAsync(replyId);
            if(x == null) throw new KeyNotFoundException();
            x.Detail = detail;
            await dbContext.SaveChangesAsync();
        }
        public async Task DeleteReply(int replyId)
        {
            var x = await dbContext.Replies.FindAsync(replyId);
            if (x == null) throw new KeyNotFoundException();
            dbContext.Replies.Remove(x);
            await dbContext.SaveChangesAsync();
        }

        public async Task<int> UpDownVoteReply(int replyId, int ctr)
        {
            var x = await dbContext.Replies.FindAsync(replyId);
            if (x == null) throw new KeyNotFoundException();
            if (ctr != -1 && ctr != 1) return x.Upvote;
            if(x.Upvote > int.MinValue && x.Upvote < int.MaxValue)
            {
                x.Upvote = x.Upvote + ctr;
                await dbContext.SaveChangesAsync();
            }
            return x.Upvote;
        }

        public async Task<int> UpDownVoteThread(int threadId, int ctr)
        {
            var x = await dbContext.Threads.FindAsync(threadId);
            if (x == null) throw new KeyNotFoundException();
            if (ctr != -1 && ctr != 1) return x.Upvote;
            if (x.Upvote > int.MinValue && x.Upvote < int.MaxValue)
            {
                x.Upvote = x.Upvote + ctr;
                await dbContext.SaveChangesAsync();
            }
            return x.Upvote;
        }
    }
}