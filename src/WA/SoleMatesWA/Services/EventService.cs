using Microsoft.EntityFrameworkCore;

using SoleMatesWA.Data;
using SoleMatesWA.Models;

namespace SoleMatesWA.Repository;

public class EventService : IEventService
{
    private readonly SoleMatesWAContext _context;
    private readonly ILogger<EventService> _logger;

    public EventService(SoleMatesWAContext context, ILogger<EventService> logger)
    {
        _context = context;
        _logger = logger;
    }

    /// <summary>
    /// Retrieves all events.
    /// </summary>
    /// <returns>A list of all events.</returns>
    public async Task<IEnumerable<EventModel>> GetEventsAsync()
    {
        try
        {
            return await _context.Events.ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while getting events.");
            throw;
        }
    }

    /// <summary>
    /// Retrieves a specific event by its ID.
    /// </summary>
    /// <param name="id">The ID of the event.</param>
    /// <returns>The event if found, otherwise null.</returns>
    public async Task<EventModel?> GetEventAsync(Guid id)
    {
        try
        {
            return await _context.Events.FindAsync(id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while getting the event with ID {EventId}.", id);
            throw;
        }
    }

    /// <summary>
    /// Adds a new event.
    /// </summary>
    /// <param name="eventModel">The event model to add.</param>
    /// <returns>The added event model.</returns>
    public async Task<EventModel> AddEventAsync(EventModel eventModel)
    {
        try
        {
            _context.Events.Add(eventModel);
            await _context.SaveChangesAsync();
            return eventModel;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while adding a new event.");
            throw;
        }
    }

    /// <summary>
    /// Updates an existing event.
    /// </summary>
    /// <param name="eventModel">The event model to update.</param>
    /// <returns>The updated event model.</returns>
    public async Task<EventModel> UpdateEventAsync(EventModel eventModel)
    {
        try
        {
            _context.Entry(eventModel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return eventModel;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while updating the event with ID {EventId}.", eventModel.Id);
            throw;
        }
    }

    /// <summary>
    /// Deletes a specific event by its ID.
    /// </summary>
    /// <param name="id">The ID of the event.</param>
    public async Task DeleteEventAsync(Guid id)
    {
        try
        {
            var eventModel = await _context.Events.FindAsync(id);

            if (eventModel != null)
            {
                _context.Events.Remove(eventModel);
                await _context.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while deleting the event with ID {EventId}.", id);
            throw;
        }
    }
}
