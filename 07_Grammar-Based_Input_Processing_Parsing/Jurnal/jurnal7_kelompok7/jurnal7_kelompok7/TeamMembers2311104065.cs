using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnal7_kelompok7
{
    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public class TeamMembers2311104065
    {
        public Member[] members { get; set; }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_2_2311104045.json");
            TeamMembers2311104065 team = JsonSerializer.Deserialize<TeamMembers2311104045>(jsonString);

            Console.WriteLine("Team member list:");
            foreach (var member in team.members)
            {
                Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
            }
        }
    }
}
