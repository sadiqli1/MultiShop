using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MultiShop.Utilites
{
    public static class FileValidator
    {
        public static async Task<string> CreateFile(this IFormFile file, string root, string folder)
        {
            string filename = string.Concat(Guid.NewGuid(), file.FileName);
            string path = Path.Combine(root, folder, filename);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return filename;
        }
        public static bool ImageisOkay(this IFormFile file, int mb)
        {
            return file.ContentType.Contains("image/") && file.Length / 1024 / 1024 < mb;
        }
        public static void DeleteFile(string root, string folder, string file)
        {
            string path = Path.Combine(root, folder, file);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
        }
    }
}
