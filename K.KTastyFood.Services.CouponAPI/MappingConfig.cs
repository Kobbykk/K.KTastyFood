using AutoMapper;
using K.KTastyFood.Services.CouponAPI.Models;
using K.KTastyFood.Services.CouponAPI.Models.Dto;

namespace K.KTastyFood.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
