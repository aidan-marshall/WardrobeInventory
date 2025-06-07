using WardrobeInventory.Models;

namespace WardrobeInventory.Services;

public interface IWardrobeService
{
    Task<WardrobeItem>  GetWardrobeItemAsync(int id);
    Task<List<WardrobeItem>> GetWardrobeItemsAsync();
    Task DeleteWardrobeItemAsync(int id);
    Task AddWardrobeItemAsync(WardrobeItem item);
    Task UpdateWardrobeItemAsync(WardrobeItem item);
}