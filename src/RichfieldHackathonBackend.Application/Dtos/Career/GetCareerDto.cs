namespace RichfieldHackathonBackend.Application.Dtos.Career;

public class GetCareerDto 
{
    public string Title { get; set; } 
    public string Description { get; set; }
    public ICollection<string> RequiredSkills { get; set; } 
}
