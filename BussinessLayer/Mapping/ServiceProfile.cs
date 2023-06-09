using BusinessLayer.DTOS;
using EntityLayer.Concrete;
using AutoMapper;
namespace BusinessLayer.Mapping
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<Service, ServiceHistory>()
            .ForMember(dest => dest.DeviceStatus, opt => opt.MapFrom(src => src.DeviceStatus))
            .ForMember(dest => dest.ServiceWorker, opt => opt.MapFrom(src => src.ServiceWorker))
            .ForMember(dest => dest.DeviceDateEntry, opt => opt.MapFrom(src => src.DeviceDateEntry))
            .ForMember(dest => dest.DeviceDeliverEntry, opt => opt.MapFrom(src => src.DeviceDeliverEntry))
            .ForMember(dest => dest.ServiceDelayStatus, opt => opt.MapFrom(src => src.ServiceDelayStatus))
            .ForMember(dest => dest.DeviceServiceReason, opt => opt.MapFrom(src => src.DeviceServiceReason))
            .ForMember(dest => dest.DeviceChangingParts, opt => opt.MapFrom(src => src.DeviceChangingParts))
            .ForMember(dest => dest.DeviceProcessingTime, opt => opt.MapFrom(src => src.DeviceProcessingTime))
            .ForMember(dest => dest.ServiceId, opt => opt.MapFrom(src => src.ServiceId))
            .ForMember(dest => dest.ServicePriority, opt => opt.MapFrom(src => src.ServicePriority)) 
            .ForMember(dest => dest.ComputerId, opt => opt.MapFrom(src => src.ComputerId)) 
            .ForMember(dest => dest.ServisStatus, opt => opt.MapFrom(src => src.ServisStatus)); 

            //CreateMap<Service, ServiceDTO>().ReverseMap();
            //CreateMap<ServiceHistory, ServiceHistoryDTO>().ReverseMap();
            
        }
    }
}
