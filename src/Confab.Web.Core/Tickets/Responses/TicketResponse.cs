using System;

public class TicketResponse
{
    public decimal? Price { get; set; }
    public DateTime PurchasedAt { get; set; }
    public ConferenceData Conference { get; set; }
}

public class ConferenceData
{
    public string Id { get; set; }
    public string Name { get; set; }
}