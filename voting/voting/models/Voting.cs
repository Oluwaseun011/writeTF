using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voting.models
{
    public class Voting
    {
        public int Id { get; set; }
        public string? StudentName { get; set; }
        public Dictionary<string, string> Votes { get; set; } = new Dictionary<string, string>();

        public Voting(int id, string studentName, Dictionary<string, string> votes)
        {
            Id = id;
            StudentName = studentName;
            Votes = votes;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var kvp in Votes)
            {
                sb.Append($"{kvp.Key}:{kvp.Value},");
            }
            return $"{Id}\t{StudentName}\t{sb}";
        }

        public static Voting ToVoting(string str)
        {
            var voting = str.Split('\t');
            var id = int.Parse(voting[0]);
            var studentName = voting[1];
            var asd = voting[2].Split(',').ToList();
            Dictionary<string, string> votes = new Dictionary<string, string>();
            foreach (var item in asd)
            {
                var qwe = item.Split(':');
                votes[qwe[0]] = qwe[1];
            }

            return new Voting(id, studentName, votes);

        }
    }
}
