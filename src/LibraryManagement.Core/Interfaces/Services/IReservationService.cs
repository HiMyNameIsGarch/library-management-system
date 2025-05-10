// src/LibraryManagement.Core/Interfaces/Services/IReservationService.cs
using LibraryManagement.Core.Entities;

namespace LibraryManagement.Core.Interfaces.Services
{
    public interface IReservationService
    {
        Task<Result<Reservation>> ReserveBook(int bookId, string userId);
        Task<Result<bool>> FulfillReservation(int reservationId);
    }
}
