using AutoMapper;
using StudentsScores.APIS.DTOS;
using StudentsScores.core.Entities;
using StudentsScores.core.Enums;

namespace StudentsScores.APIS.helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ScoreSubject, ScoreDto>();
            CreateMap<SubjectEnum, Subject>();
            CreateMap<Student, StudentDto>()
                .ForMember(d => d.Subject, O => O.MapFrom(S => S.Subject.Value))
                .ForMember(d => d.Scores, O => O.MapFrom(S => S.Scores));

            

        }
    }
}
