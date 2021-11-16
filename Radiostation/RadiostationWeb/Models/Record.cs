using System;


namespace RadiostationWeb.Models
{
    public partial class Record
    {
        public int Id { get; set; }
        public int PerformerId { get; set; }
        public int GenreId { get; set; }
        public string Album { get; set; }
        public DateTime RecordDate { get; set; }
        public int Lasting { get; set; }
        public decimal Rating { get; set; }
        public string ComposName { get; set; }

    }
}
