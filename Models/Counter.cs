using System.Text;

namespace BlazorServer.Models
{
    public class Counter
    {
        public int Counter1 { get; set; }

        public int Counter2 { get; set; }

        public int Counter3 { get; set; }

        public int Counter4 { get; set; }

        public StringBuilder Log { get; set; } = new();
    }
}
