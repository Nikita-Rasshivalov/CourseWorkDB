using System;

namespace RadiostationBLL.ModelsDto
{
    public class RecordDto
    {
        public int Id { get; set; }
        public string СompositionName { get; set; }
        public int PerformerId { get; set; }
        public int GenreId { get; set; }
        public string Album { get; set; }
        public DateTime RecordDate { get; set; }
        public int Lasting { get; set; }
        public decimal Rating { get; set; }
    }
}
