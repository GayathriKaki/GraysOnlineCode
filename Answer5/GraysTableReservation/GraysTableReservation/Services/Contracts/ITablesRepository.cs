using System.Collections.Generic;
using System.Linq;
using Reservation = GraysTableReservation.Services.Domain.Reservation;
using Table = GraysTableReservation.Services.Domain.Table;

namespace GraysTableReservation.Services.Contracts
{
    public interface ITablesRepository
    {
        IQueryable<Table> QueryTables();
        IQueryable<Reservation> QueryReservations();
        bool AddOrUpdateReservation(Models.Reservation reservation);
        bool DeleteReservation(Models.Reservation reservation);

        List<Models.Reservation> GetAllReservations();
        List<Models.Reservation> GetAllReservationsSortedByTableAndTime();

        int GetBiggestTableSize();
      
        List<Table> GetAllDomainTablesSortedByMaxOccupancy();
        List<Reservation> GetAllDomainReservations();

        List<Models.Table> GetAllTables();
    }
}
