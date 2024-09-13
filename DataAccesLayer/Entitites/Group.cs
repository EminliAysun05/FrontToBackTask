namespace FrontToBack.DataAccesLayer.Entitites
{
    public class Group:Entity
    {
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<TeacherGroup> Teachers { get; set; } = new List<TeacherGroup>();
    }
}
