namespace FunOlympicProject.Models
{
    public class Videos
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime PublishedDate { get; set; }= DateTime.Now;

        public string Category { get; set; }

        public string Videolink { get; set; }

        public string Thumbnaillink { get; set; }

        public string Description { get; set; }
    }
}
