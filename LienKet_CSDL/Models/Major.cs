namespace LienKet_CSDL.Models
{
    public class Major
    {
        public int MajorID { get; set; }
        public string MajorName { get; set; }
        public ICollection<Learner> Learners { get; set; }
    }
}
