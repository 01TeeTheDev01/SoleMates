﻿using SoleMatesWA.Models;

namespace SoleMatesWA.Repository;

public interface IEventRepository
{
    Task<IEnumerable<EventModel>> GetEventsAsync();
    Task<EventModel?> GetEventAsync(Guid id);
    Task<EventModel> AddEventAsync(EventModel eventModel);
    Task<EventModel> UpdateEventAsync(EventModel eventModel);
    Task DeleteEventAsync(Guid id);
}