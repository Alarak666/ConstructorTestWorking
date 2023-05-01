using Data.Data.Identity;

namespace Data.Data.InformationData;

public class TestOnServer
{
    public Guid Id { get; set; }
    public ApplicationUser? Author { get; set; }
    public Guid? AuthorId { get; set; }
    public string? AuthorUserName { get; set; }
    public string FileName { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Info { get; set; } = string.Empty;
    public decimal Percent { get; set; }
    public decimal? CountQuestion { get; set; }
    public decimal? MaximumPoint { get; set; }
    public string Root { get; set; }
}