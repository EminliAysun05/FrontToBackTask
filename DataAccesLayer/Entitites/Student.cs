namespace FrontToBack.DataAccesLayer.Entitites
{
    public class Student:Entity
    {
        public string Name { get; set; }

        //public int GroupId { get; set; }
        public override string ToString()
        {
            return $"{Id}, {Name}";
        }
    }
}
