﻿using StudentsScores.core.Entities;
using StudentsScores.core.Enums;

namespace StudentsScores.APIS.DTOS
{
    public class StudentSeedData
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string LearningObjective { get; set; }
        public string Score { get; set; }
        public string Subject { get; set; }
    }
}
