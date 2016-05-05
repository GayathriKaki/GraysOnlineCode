namespace GraysTableReservation.Models
{
    public class Table : ModelBase
    {
        public int TableId { get; set; }
        public int MaxOccupancy { get; set; }
    }
}
