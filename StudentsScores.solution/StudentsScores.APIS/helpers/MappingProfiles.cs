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
            CreateMap<Student, StudentDto>()
                .ForMember(d => d.StudentId, o => o.MapFrom(S => S.Id))
                .ForMember(d => d.Subject, o => o.MapFrom(S => S.Subject.Value));
                //.ForMember(d => dest.Scores, o => o.ResolveUsing<ScoresResolver>());
        }

        public class ScoresResolver : IValueResolver<Student, StudentDto, List<ScoreDto>>
        {
            public List<ScoreDto> Resolve(Student source, StudentDto destination, List<ScoreDto> destMember, ResolutionContext context)
            {
                return context.Mapper.Map<List<ScoreDto>>(source.Scores);
            }
        }

    }
}
