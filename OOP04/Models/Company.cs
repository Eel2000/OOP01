namespace OOP04.Models
{
    public abstract class Company
    {
        protected Company(string name, string description, DateTime creationDate, bool isActive)
        {
            Name = name;
            IsActive = isActive;
            Description = description;
            CreationDate = creationDate;

            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }

        public virtual int CalculateAges()
        {
            return DateTime.Now.Year - CreationDate.Year;
        }
    }
}
