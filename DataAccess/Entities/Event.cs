using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.DataAccess.Entities
{
    public class Event
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public TimeSpan StartTime { get; set; }  
        public TimeSpan EndTime { get; set; }    
        public string Location { get; set; }
        public string ImageUrl { get; set; }


    }
}
