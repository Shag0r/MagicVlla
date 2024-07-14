using MagicVilla_Web_new.Models.Dto;

namespace MagicVilla_Web_new.Services.IServices
{
    public interface IVillaServices
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreatedAsynce<T>(VillaCreateDTO dto);
        Task<T> UpdateAsync<T>(VillaUpdateDTO dto);
        Task<T> DeleteAsync<T>(int id);
       // Task RemoveAsync(int id);
    }
}
