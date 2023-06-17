using Fiorello_backend.ViewModels;

namespace Fiorello_backend.Services.Interfaces
{
    public interface ILayoutService
    {
      public  Task<LayoutVM> GetAllDatas();
    }
}
