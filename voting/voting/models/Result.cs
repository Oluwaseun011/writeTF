using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voting.models
{
    public class Result
    {
        public int Id { get; set; }
        public string? ElectionName { get; set; }
        public Dictionary<string, Dictionary<string, int>> Scores { get; set; } = new Dictionary<string, Dictionary<string, int>>();

        public Result(int id, string electionName, Dictionary<string, Dictionary<string, int>> scores)
        {
            Id = id;
            ElectionName = electionName;
            Scores = scores;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Scores)
            {
                sb.Append($"{item.Key}=>");
                foreach (var kvp in item.Value)
                {
                    sb.Append($"{kvp.Key}:{kvp.Value} ");
                }
                sb.Append(' ');
            }
            return $"{Id}\t{ElectionName}\t{sb}";
        }

        public static Result ToResult(string str)
        {
            var result = str.Split('\t');
            var id = int.Parse(result[0]);
            var electionName = result[1];
            
            
            var asd = result[2].Split(", ");
            Dictionary<string, Dictionary<string, int>> lop = new Dictionary<string, Dictionary<string, int>>();
            foreach (var kvp in asd)
            {
                var qwe = kvp.Split("=>");
                Dictionary<string, int> pol = new Dictionary<string, int>();
                var iuy = qwe[1].Split(' ');
                foreach (var kvpk in iuy)
                {
                    var poil = kvpk.Split(':');
                    pol.Add(poil[0], int.Parse(poil[1]));
                }

                lop.Add(qwe[0], pol);

            }

            return new Result(id, electionName, lop);
            
        }
    }

    
}
