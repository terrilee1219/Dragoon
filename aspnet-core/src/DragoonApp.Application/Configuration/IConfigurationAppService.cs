using System.Threading.Tasks;
using DragoonApp.Configuration.Dto;

namespace DragoonApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
