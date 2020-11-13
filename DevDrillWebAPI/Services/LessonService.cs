using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevDrillWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DevDrillWebAPI.Services
{
    public class LessonService
    {
        private readonly DevDrillDbContext dbContext;

        public LessonService(DevDrillDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<LessonGroupModel>> GetLessons(int courseId)
        {
            var lessonGroups = await dbContext.LessonGroup.Where(e => e.CourseId == courseId).ToListAsync();
            List<LessonGroupModel> lessonGroupModels = new List<LessonGroupModel>();

            foreach (var lessonGroup in lessonGroups)
            {
                var lessonModels = await dbContext.Lesson
                    .Where(e => e.LessonGroupId == lessonGroup.LessonGroupId)
                    .Select(e => new LessonModel()
                    {
                        LessonDescription = e.LessonDescription,
                        LessonId = e.LessonId,
                        LessonName = e.LessonName,
                        LessonEndTime = e.LessonEndTime,
                        LessonGroupId = e.LessonGroupId,
                        LessonStartTime = e.LessonStartTime
                    }).ToListAsync();
                lessonGroupModels.Add(new LessonGroupModel()
                {
                    LessonGroupId = lessonGroup.LessonGroupId,
                    LessonGroupName = lessonGroup.LessonGroupName,
                    Lessons = lessonModels
                });
            }

            return lessonGroupModels;
        }
    }
}