namespace College_Po.Models
{
    public class College
    {

        public int Id { get; set; }

        public String ? Name { get; set; }

        public String ? Place{ get; set; }

        public String ? District { get; set; }

        internal static object Find(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
