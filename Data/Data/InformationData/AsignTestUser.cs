using Data.Data.Identity;

namespace Data.Data.InformationData;

public class AsignTestUser
{
    public Guid Id { get; set; }
    public ApplicationUser? User { get; set; }
    public Guid? UserId { get; set; }
    public TestOnServer? TestOnServer { get; set; }
    public Guid? TestOnServerId { get; set; }
    public string UserUserName { get; set; }
    public string UserNormalizedUserName { get; set; }
    public decimal TestScore { get; set; }
    public TimeSpan? TimeForTheTest { get; set; }
    public DateTime? CompleteTestDateTime { get; set; }
    public TimeSpan? TestDateTime { get; set; }
    public string AnswerRoot { get; set; } = string.Empty;
    public decimal CountContinue { get; set; }
    public decimal TestScoreHigh { get; set; }

}