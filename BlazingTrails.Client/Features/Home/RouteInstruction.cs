namespace BlazingTrails.Client.Features.Home
{
    // Represents a waypoint on the route to help guide other walkers
    public class RouteInstruction
    {
        public int Stage { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
