using LibraryManagement.Core.Entities;

namespace LibraryManagement.Core.Interfaces.Repositories
{
    public interface IReservationRepository
    {
        Task Add(Reservation reservation);
        Task Update(Reservation reservation);
        Task<Reservation?> GetById(int id);
        Task<IEnumerable<Reservation>> GetActiveReservations(int bookId);
    }
}
