using System.Collections.Generic;

namespace DevDrillAPI.Dto
{
    public class DiscussionGroupDto

    {
        public int DiscussionGroupId { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }

        public List<DiscussionDto> Discussions { get; set; }
    }

}