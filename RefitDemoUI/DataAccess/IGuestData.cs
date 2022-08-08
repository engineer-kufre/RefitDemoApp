using Refit;
using RefitDemoUI.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefitDemoUI.DataAccess
{
    public interface IGuestData
    {
        [Get("/Guests")]
        Task<List<GuestDto>> GetGuests();

        [Get("/Guests/{id}")]
        Task<GuestDto> GetGuest(int id);

        [Post("/Guests")]
        Task CreateGuest([Body] GuestDto guest);

        [Put("/Guest/{id}")]
        Task UpdateGuest(int id, [Body] GuestDto guest);

        [Delete("/Guests/{id}")]
        Task DeleteGuest(int id);
    }
}
