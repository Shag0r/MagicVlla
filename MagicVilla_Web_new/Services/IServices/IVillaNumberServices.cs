using MagicVilla_Web_new.Models.Dto;

namespace MagicVilla_Web_new.Services.IServices
{
    public interface IVillaNumberServices
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreatedAsynce<T>(VillaNumberCreateDTO dto);
        Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto);
        Task<T> DeleteAsync<T>(int id);
        // Task RemoveAsync(int id);
       
    }
}
