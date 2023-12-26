namespace HireWise.Application.Dto
{
    public class SchoolExperienceDto
    {
        public string SchoolName { get; set; }

        public string SchoolType { get; set; }

        public decimal Grade { get; set; }

        public DateTime SchoolDateOfStartOnUtc { get; set; }

        public DateTime? SchoolDateOfEndOnUtc { get; set; }
    }
}
