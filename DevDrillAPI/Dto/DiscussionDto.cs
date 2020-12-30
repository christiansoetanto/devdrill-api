using System.Collections.Generic;

namespace DevDrillAPI.Dto
{
    public class DiscussionDto

    {
        public int DiscussionId { get; set; }
        public string Name { get; set; }
        public List<ThreadDto> Threads { get; set; }
        public int DiscussionGroupId { get; set; }
        public DiscussionGroupDto DiscussionGroup { get; set; }
    }
    
}