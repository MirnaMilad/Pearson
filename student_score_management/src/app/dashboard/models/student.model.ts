export interface Student {
  studentId: number;
  name: string;
  subject: {
    value: string;
    id: number;
  };
  scores: [
    {
      studentId: number;
      learningObjective: string;
      score: string;
      id: number;
    }
  ];
}
