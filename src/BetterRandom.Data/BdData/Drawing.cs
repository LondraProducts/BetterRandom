using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterRandom.Data.BdData
{
    public class Drawing
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int ParticipantsIds { get; set; }
        public int WinnerIds { get; set; }
        public int BlockIds { get; set; }
    }
}
