using K.KTastyFood.Web.Models;

namespace K.KTastyFood.Web.Service.IService
{
    public interface IBaseService
    {
       Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
