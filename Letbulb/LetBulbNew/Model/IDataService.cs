using System.Threading.Tasks;

namespace LetBulbNew.Model
{
    public interface IDataService
    {
        Task<DataItem> GetData();
    }
}