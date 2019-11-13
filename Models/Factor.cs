using System;
using System.Collections.Generic;

namespace NetPcl.Models
{
    public enum FactorType {
        Check, Procedure
    }

    public enum LevelChangeDifficulty {
        VeryEasy=0,
        Easy=1,
        Medium=2,
        Hard=3,
        VeryHard=4
    }

    public class Factor {
        public string Id { get; set; }
        public string Name {get; set; }
        public string Tags { get; set; }
        public List<Level> Levels { get; set; } = new List<Level>();
        public FactorType Type { get; set; }
        public LevelChangeDifficulty ChangeDifficulty { get; set; } = LevelChangeDifficulty.Medium;
    }
}