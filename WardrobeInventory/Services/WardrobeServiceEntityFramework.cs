using Microsoft.EntityFrameworkCore;
using WardrobeInventory.Data;
using WardrobeInventory.Models;

namespace WardrobeInventory.Services;

public class WardrobeServiceEntityFramework(WardrobeInventoryContext dbContext) : IWardrobeService
{
    public async Task<WardrobeItem> GetWardrobeItemAsync(int id)
    {
        var item = await dbContext.WardrobeItems.FindAsync(id);
        return item ?? throw new KeyNotFoundException($"Wardrobe item with ID {id} was not found.");
    }

    public async Task<List<WardrobeItem>> GetWardrobeItemsAsync()
    {
        return await dbContext.WardrobeItems.ToListAsync();
    }

    public async Task DeleteWardrobeItemAsync(int id)
    {
        dbContext.WardrobeItems.Remove(await dbContext.WardrobeItems.FindAsync(id) ??
                                       throw new InvalidOperationException());
        await dbContext.SaveChangesAsync();
    }

    public async Task AddWardrobeItemAsync(WardrobeItem item)
    {
        await dbContext.WardrobeItems.AddAsync(item);
        await dbContext.SaveChangesAsync();
    }

    public async Task UpdateWardrobeItemAsync(WardrobeItem item)
    {
        dbContext.Attach(item).State = EntityState.Modified;
        await dbContext.SaveChangesAsync();
    }
}