using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DevDrillAPI.Dto;
using DevDrillAPI.Services;
using System.Collections.Generic;
using System.Linq;


namespace DevDrillAPI.Controllers
{
    [Route("")]
    [ApiController]
    public class ForumController : ControllerBase
    {
        private readonly ForumService forumService;

        public ForumController(ForumService forumService)
        {
            this.forumService = forumService;
        }

        public async Task<IActionResult> GetDiscussionGroup()
        {
            return Ok(await forumService.GetDiscussionGroup() ?? new List<DiscussionGroupDto>());
        }

        public async Task<IActionResult> GetThreads(int discussionId)
        {
            return Ok(await forumService.GetThreads(discussionId) ?? new List<ThreadDto>());
        }

        public async Task<IActionResult> GetReplies(int threadId)
        {
            return Ok(await forumService.GetReplies(threadId) ?? new List<ReplyDto>());
        }

        public async Task<IActionResult> InsertThread(int userId, ThreadDto threadDto)
        {
            await forumService.InsertThread(userId, threadDto.DiscussionId, threadDto.Topic, threadDto.Detail);
            return Ok();
        }

        public async Task<IActionResult> InsertReply(int userId, ReplyDto replyDto)
        {
            await forumService.InsertReply(userId, replyDto.ThreadId, replyDto.Detail);
            return Ok();
        }

    }
}