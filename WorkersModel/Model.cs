
namespace WorkersModel
{
    public class Worker
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Position { get; set; }

        public override string ToString()
        {
            return Name.ToString()+" "+Position.ToString()+" "+Age.ToString();
        }
    }
}
