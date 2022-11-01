using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voting.models
{
    public class Election
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? ElectionDate { get; set; }
        public double ElectionPeriod { get; set; }
        public List<string> Positions { get; set; }

        public Election(int id, string name, string description, DateTime electionDate, double electionPeriod, List<string> postions )
        {
            Id = id;
            Name = name;
            Description = description;
            ElectionDate = electionDate;
            ElectionPeriod = electionPeriod;
            Positions = postions;
        }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Description}\t{ElectionDate}\t{ElectionPeriod}\t{String.Join(',',Positions)}";
        }

        public static Election ToElection(string str)
        {
            var election = str.Split('\t');
            var id = int.Parse(election[0]);
            var name = election[1];
            var description = election[2];
            var electionDate = DateTime.Parse(election[3]);
            var electionPeriod = double.Parse(election[4]);
            var positions = election[5].Split(',').ToList();

            return new Election(id, name, description, electionDate, electionPeriod, positions);
        }


    }
}
