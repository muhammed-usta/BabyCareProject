using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.DataAccess.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Capacity { get; set; }
        public string LessonCount { get; set; }
        public string Duration { get; set; }
        public string ImageUrl { get; set; }

        public string InstructorName { get; set; }
        public string InstructorTitle { get; set; }




    }
}
