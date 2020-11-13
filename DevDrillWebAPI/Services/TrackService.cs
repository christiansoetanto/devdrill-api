using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevDrillWebAPI.Entities.DevDrillDB;
using DevDrillWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DevDrillWebAPI.Services
{
    public class TrackService
    {
        private readonly DevDrillDbContext _dbContext;

        public TrackService(DevDrillDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<TrackGroupModel>> GetTracks()
        {
            var trackGroups = await _dbContext.TrackGroup.ToListAsync();
            List<TrackGroupModel> trackGroupModels = new List<TrackGroupModel>();
            foreach (var trackGroup in trackGroups)
            {
                var trackModels = await _dbContext.Track
                    .Where(e => e.TrackGroupId == trackGroup.TrackGroupId)
                    .Select(e => new TrackModel()
                    {
                        TrackDescription = e.TrackDescription,
                        TrackId = e.TrackId,
                        TrackName = e.TrackName,
                        TrackGroupId = e.TrackGroupId
                    }).ToListAsync();
                trackGroupModels.Add(new TrackGroupModel()
                {
                    TrackGroupId = trackGroup.TrackGroupId,
                    TrackGroupName = trackGroup.TrackGroupName,
                    Tracks = trackModels
                });
            }

            return trackGroupModels;
        }
    }
}