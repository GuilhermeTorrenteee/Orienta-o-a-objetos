using Objeto.ContentContext.Enums;
using Objeto.SharedContext;

namespace Objeto.ContentContext
{
    public class Lecture : Base
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}