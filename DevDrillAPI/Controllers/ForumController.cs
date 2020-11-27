using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DevDrillAPI.Dto;
using DevDrillAPI.Services;
using System.Collections.Generic;
using DevDrillAPI.Helper.Extensions;
using System.Text.Json;
using System;

namespace DevDrillAPI.Controllers
{
    [Route("forum")]
    [ApiController]
    public class ForumController : ControllerBase
    {
        private readonly ForumService forumService;

        public ForumController(ForumService forumService)
        {
            this.forumService = forumService;
        }
        [HttpGet("discussions")]
        public async Task<IActionResult> GetDiscussionGroup()
        {
            return Ok(await forumService.GetDiscussionGroup() ?? new List<DiscussionGroupDto>());
        }
        [HttpGet("discussions/{discussionId}/threads")]
        public async Task<IActionResult> GetThreads(int discussionId)
        {
            return Ok(await forumService.GetThreads(discussionId) ?? new List<ThreadDto>());
        }
        [HttpGet("threads/{threadId}/replies")]
        public async Task<IActionResult> GetReplies(int threadId)
        {
            return Ok(await forumService.GetReplies(threadId) ?? new List<ReplyDto>());
        }
        [HttpPost("threads")]
        public async Task<IActionResult> InsertThread([FromBody]JsonElement body)
        {
            int userId = body.GetProperty("userId").GetInt32();
            ThreadDto threadDto = body.GetProperty("threadDto").GetObject<ThreadDto>();
            await forumService.InsertThread(userId, threadDto.DiscussionId, threadDto.Topic, threadDto.Detail);
            return Ok();
        }
        [HttpPost("replies")]
        public async Task<IActionResult> InsertReply([FromBody]JsonElement body)
        {
            int userId = body.GetProperty("userId").GetInt32();
            ReplyDto replyDto = body.GetProperty("replyDto").GetObject<ReplyDto>();
            await forumService.InsertReply(userId, replyDto.ThreadId, replyDto.Detail);
            return Ok();
        }

    }
}