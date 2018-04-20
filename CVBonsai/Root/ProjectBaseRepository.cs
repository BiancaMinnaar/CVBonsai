using CVBonsai.Interface.Repository;
using PCLBase.DataContracts;

namespace CVBonsai.Root.Repository
{
    public class ProjectBaseRepository : BaseRepository
    {
        protected IMasterRepository _MasterRepo;

        public ProjectBaseRepository(IMasterRepository masterRepository)
        {
            _MasterRepo = masterRepository;
        }
    }
}
