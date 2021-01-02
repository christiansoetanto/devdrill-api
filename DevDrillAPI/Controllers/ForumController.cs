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
        public async Task<IActionResult> GetDiscussionGroups()
        {
            return Ok(await forumService.GetDiscussionGroups() ?? new List<DiscussionGroupDto>());
        }
        [HttpGet("discussions/{id}")]
        public async Task<IActionResult> GetDiscussion(int id)
        {
            return Ok(await forumService.GetDiscussion(id) ?? new DiscussionDto());
        }
        [HttpGet("discussions/{discussionId}/threads")]
        public async Task<IActionResult> GetThreadsByDiscussionId(int discussionId)
        {
            return Ok(await forumService.GetThreadsByDiscussionId(discussionId) ?? new List<ThreadDto>());
        }
        [HttpGet("threads/{id}")]
        public async Task<IActionResult> GetThread(int id)
        {
            return Ok(await forumService.GetThread(id) ?? new ThreadDto());
        }
        [HttpGet("threads/{threadId}/replies")]
        public async Task<IActionResult> GetRepliesByThreadId(int threadId)
        {
            return Ok(await forumService.GetRepliesByThreadId(threadId) ?? new List<ReplyDto>());
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
                int id = body.GetProperty("threadId").GetInt32();
                string topic = body.GetProperty("topic").GetString();
                string detail = body.GetProperty("detail").GetString();
                await forumService.UpdateThread(id, topic, detail);
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
                int id = body.GetProperty("replyId").GetInt32();
                string detail = body.GetProperty("detail").GetString();
                await forumService.UpdateReply(id, detail);
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
        [HttpDelete("replies/{id}")]
        public async Task<IActionResult> DeleteReply(int id)
        {
            try
            {
                await forumService.DeleteReply(id);
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