using System;

namespace DevDrillAPI.Dto
{
    public class ReplyDto

    {
        public int ReplyId { get; set; }
        public DateTime InsertDate { get; set; }
        public string Detail { get; set; }

        public UserDto User { get; set; }
        public int Upvote { get; set; }
        
        public int ThreadId { get; set; }
        //Untuk ThreadStarter
        public string Topic { get; set; }
        
    }


}