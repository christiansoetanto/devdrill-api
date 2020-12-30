using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DevDrillAPI.Dto;
using DevDrillAPI.Services;
using System.Collections.Generic;
using DevDrillAPI.Helper.Extensions;
using System.Text.Json;
using System;
using System.Linq;

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
        [HttpGet("discussions/{discussionId}")]
        public async Task<IActionResult> GetDiscussion(int discussionId)
        {
            return Ok(await forumService.GetDiscussion(discussionId) ?? new DiscussionDto());
        }
        [HttpGet("discussions/{discussionId}/threads")]
        public async Task<IActionResult> GetThreads(int discussionId)
        {
            return Ok(await forumService.GetThreads(discussionId) ?? new List<ThreadDto>());
        }
        [HttpGet("threads/{threadId}")]
        public async Task<IActionResult> GetThread(int threadId)
        {
            return Ok(await forumService.GetThread(threadId) ?? new ThreadDto());
        }
        [HttpGet("threads/{threadId}/replies")]
        public async Task<IActionResult> GetReplies(int threadId)
        {
            return Ok(await forumService.GetReplies(threadId) ?? new List<ReplyDto>());
        }
        [HttpPost("threads")]
        public async Task<IActionResult> InsertThread([FromBody]JsonElement body)
        {
            try
            {
                int userId = body.GetProperty("userId").GetInt32();
                ThreadDto threadDto = body.GetProperty("threadDto").GetObject<ThreadDto>();
                await forumService.InsertThread(userId, threadDto.DiscussionId, threadDto.Topic, threadDto.Detail);
                return Ok();
            }
            catch(Exception e)
            {
                return StatusCode(500);
            }
        }
        [HttpPut("threads")]
        public async Task<IActionResult> UpdateThread([FromBody] JsonElement body)
        {
            try
            {
                int threadId = body.GetProperty("threadId").GetInt32();
                string topic = body.GetProperty("topic").GetString();
                string detail = body.GetProperty("detail").GetString();
                await forumService.UpdateThread(threadId, topic, detail);
                return Ok();
            }
            catch (KeyNotFoundException e)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }
        [HttpPost("replies")]
        public async Task<IActionResult> InsertReply([FromBody]JsonElement body)
        {
            try
            {
                int userId = body.GetProperty("userId").GetInt32();
                ReplyDto replyDto = body.GetProperty("replyDto").GetObject<ReplyDto>();
                await forumService.InsertReply(userId, replyDto.ThreadId, replyDto.Detail);
                return Ok();
            }
            catch(Exception e)
            {
                return StatusCode(500);
            }
        }
        [HttpPut("replies")]
        public async Task<IActionResult> UpdateReply([FromBody] JsonElement body)
        {
            try
            {
                int replyId = body.GetProperty("replyId").GetInt32();
                string detail = body.GetProperty("detail").GetString();
                await forumService.UpdateReply(replyId, detail);
                return Ok();
            }
            catch (KeyNotFoundException e)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }
        [HttpDelete("replies/{replyId}")]
        public async Task<IActionResult> DeleteReply(int replyId)
        {
            try
            {
                await forumService.DeleteReply(replyId);
                return Ok();
            }
            catch (KeyNotFoundException e)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }
        [HttpPost("threads/vote")]
        public async Task<IActionResult> UpDownVoteThread([FromBody] JsonElement body)
        {
            try
            {
                int threadId = body.GetProperty("threadId").GetInt32();
                int counter = body.GetProperty("counter").GetInt32();
                int result = await forumService.UpDownVoteThread(threadId, counter);
                return Ok(result);
            }
            catch(KeyNotFoundException e)
            {
                return NotFound();
            }
            catch(Exception e)
            {
                return StatusCode(500);
            }
        }
        [HttpPost("replies/vote")]
        public async Task<IActionResult> UpDownVoteReply([FromBody] JsonElement body)
        {
            try
            {
                int replyId = body.GetProperty("replyId").GetInt32();
                int counter = body.GetProperty("counter").GetInt32();
                int result = await forumService.UpDownVoteReply(replyId, counter);
                return Ok(result);
            }
            catch (KeyNotFoundException e)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }
    }
 }