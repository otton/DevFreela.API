using DevFreela.API.Controllers;
using DevFreela.API.Enums;
using DevFreela.API.Models;

namespace DevFreela.API.Entities
{
    public class Project : BaseEntity
    {
        public Project(){ }
        public Project(string title, string description, int idClient, User client, int idFreelance, User freelancer, decimal totalCost)
            : base()
        {
            Title = title;
            Description = description;
            IdClient = idClient;
            IdFreelance = idFreelance;
            TotalCost = totalCost;

            Status = ProjectStatusEnum.Created;
            Comments = [];
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public int IdClient { get; private set; }
        public User Client { get; private set; }
        public int IdFreelance { get; private set; }
        public User Freelancer { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? CompletedAt { get; private set; }
        public ProjectStatusEnum Status { get; private set; }
        public List<ProjectComment> Comments { get; private set; }


        public void Cancel()
        {
            if (Status == ProjectStatusEnum.InProgress || Status == ProjectStatusEnum.Suspended)
            {
                Status = ProjectStatusEnum.Cancelled;
            }
        }

        public void Start()
        {
            if (Status == ProjectStatusEnum.Created)
            {
                Status = ProjectStatusEnum.InProgress;
                StartedAt = DateTime.Now;
            }
        }

        public void Complete()
        {
            if (Status == ProjectStatusEnum.PaymentPending)
            {
                Status = ProjectStatusEnum.Completed;
                CompletedAt = DateTime.Now;
            }
            
        }

        public void SetPaymentPending()
        {
            if (Status == ProjectStatusEnum.InProgress)
            {
                Status = ProjectStatusEnum.PaymentPending;
            }
        }

        public void Update(string title, string description, decimal totalcost)
        {
            Title = title;
            Description = description;
            TotalCost = totalcost;
        }
    }
}
