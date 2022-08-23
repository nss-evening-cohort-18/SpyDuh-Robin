namespace SpyDuh_Robin.Models
{
    public class Spy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Skills { get; set; }
        public List<string> Services { get; set; }
        public List<int> Friends { get; set; }
        public List<int> Enemies { get; set; }
        public string AgencyName { get; set; }
        public string Assignment { get; set; }
        public DateTime AssignmentDueDate { get; set; }

        public Spy(int id, string name, List<string> skills, List<string> services, List<int> friends, List<int> enemies, string agencyName, string assignment, DateTime assignmentDueDate)
        {
            Id = id;
            Name = name;
            Skills = skills; //do we need to initialize this list?
            Services = services; //do we need to initiliaze this list?
            Friends = friends; //do we need to initialize this list?
            Enemies = enemies; //do we need to initialize this list?
            AgencyName = agencyName;
            Assignment = assignment;
            AssignmentDueDate = assignmentDueDate;
        }
        
    }
}
