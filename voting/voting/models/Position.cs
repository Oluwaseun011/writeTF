using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voting.models
{
    public class Position
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<string> Contestants { get; set; } = new List<string>();

        public Position(int id, string name, string description, List<string> contestants)
        {
            Id = id;
            Name = name;
            Description = description;
            Contestants = contestants;

        }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Description}\t{String.Join(',', Contestants)}";
        }

        public static Position ToPosition(string str)
        {
            var position = str.Split('\t');
            var id = int.Parse(position[0]);
            var name = position[1];
            var description = position[2];
            var contestants = position[3].Split(',').ToList();

            return new Position(id, name, description, contestants);
            


        }

    }
}
