namespace HireWise.Application.Dto
{
    public class WorkExperienceDto
    {
        public string CompanyName { get; set; }
        public string Departmant { get; set; }
        public string Position { get; set; }
        public DateTime WorkDateOfStart { get; set; }
        public DateTime? WorkDateOfEnd { get; set; }
    }
}
