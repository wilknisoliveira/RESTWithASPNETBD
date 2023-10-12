using RESTWithASPNETBD.Data.VO;

namespace RESTWithASPNETBD.Business
{
    public interface IFileBusiness
    {
        //Upload a file
        public Byte[] GetFile(string filename);
        //Download a file
        public Task<FileDetailVO> SaveFileToDisk(IFormFile file);
        //Download multiples files
        public Task<List<FileDetailVO>> saveFilesToDisk(IList<IFormFile> file);
    }
}
