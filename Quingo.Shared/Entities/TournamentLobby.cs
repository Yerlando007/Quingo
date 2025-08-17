using Quingo.Shared.Entities;

public class TournamentLobby : EntityBase
{
    public string HostUserId { get; set; } = default!;
    public string HostUserName { get; set; } = default!;
    public int PackId { get; set; }
    public string PackName { get; set; } = default!;
    public string? Password { get; set; }
    public int MaxPlayers { get; set; } = 4;
    public ICollection<LobbyParticipant> Participants { get; set; } = new List<LobbyParticipant>();
}