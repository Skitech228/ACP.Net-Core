using System.Threading.Tasks;

namespace ACP.Net_Core.Models.Interfases
{
    public interface ITablesTasks
    {
        Task AddInformation();

        Task DeleteInformation();

        Task UpdateInformation();

        Task ShowInformation();

    }
}