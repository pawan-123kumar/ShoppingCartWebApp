//namespace ShoppingCartWebApp.Repository
//{
//    public class FileService : IFileService
//    {
//        private readonly IWebHostEnvironment _environment;
//        public FileService(IWebHostEnvironment env)
//        {
//            this._environment = env;
//        }
//        public Tuple<int, string> SaveImage(IFormFile imageFile)
//        {
//            try
//            {
//                var contentPath = this._environment.ContentRootPath;
//                var path = Path.Combine(contentPath, imageFile.Name);
//                if (!Directory.Exists(path))
//                {
//                    Directory.CreateDirectory(path);
//                }
//                var ext = Path.GetExtension(imageFile.FileName);
//                var allowedExtensions = new String[] { ".jpg", ".png", ".jpeg" };
//                if(!allowedExtensions.Contains(ext))
//                {
//                    string msg = string.Format("Only {0} extension are allowed", string.Join(",", allowedExtensions));
//                    return new Tuple<int, string>(0, msg);
//                }
//                string uniqueString = Guid.NewGuid().ToString();
//                var newFileName = uniqueString + ext;
//                var fileWithpath = Path.Combine(path, newFileName);
//                var stream = new FileStream(fileWithpath, FileMode.Create);
//                imageFile.CopyTo(stream);
//                stream.Close();
//                return new Tuple<int, string>(1, newFileName);
//            }
//            catch {
//                return new Tuple<int, string>(0, "Error has been occured");
//            }
//        }
//    }
//}
