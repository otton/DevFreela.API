namespace DevFreela.API.Entities
{
    public class ProjectComment : BaseEntity
    {
        public ProjectComment(string content, Project project, int idUser) : base()
        {
            Content = content;
            Project = project;
            IdUser = idUser;
        }

        public string Content { get; private set; }
        public int IdProject { get; private set; }
        public Project Project { get; private set; }
        public int IdUser { get; private set; }
        public User User { get; private set; }
    }
}
