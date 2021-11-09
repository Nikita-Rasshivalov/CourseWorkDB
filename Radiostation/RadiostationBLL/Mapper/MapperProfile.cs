using AutoMapper;
using RadiostationBLL.ModelsDto;
using RadiostationDAL.Entities;

namespace RadiostationBLL.Mapper
{
    class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<BroadcastSchedule, BroadcastScheduleDto>();
            CreateMap<BroadcastScheduleDto, BroadcastSchedule>();
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();
            CreateMap<Genre, GenreDto>();
            CreateMap<GenreDto, Genre>();
            CreateMap<Group, GroupDto>();
            CreateMap<GroupDto, Group>();
            CreateMap<Performer, PerformerDto>();
            CreateMap<PerformerDto, Performer>();
            CreateMap<Record, RecordDto>();
            CreateMap<RecordDto, Record>();

        }
    }
}
