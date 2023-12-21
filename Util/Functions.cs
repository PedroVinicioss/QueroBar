using Newtonsoft.Json.Linq;
using System.Security.Cryptography;

namespace QueroBar.Util
{
    public class Functions
    {
        public static string WriteFile(IFormFile img, int user_Id, string user_name, string fileName)
        {
            string caminhoCompleto = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images", user_Id + "_" + user_name.ToString());

            if (!Directory.Exists(caminhoCompleto))
            {
                Directory.CreateDirectory(caminhoCompleto);
            }

            string path = Path.Combine(caminhoCompleto, fileName + System.IO.Path.GetExtension(img.FileName));

            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                img.CopyTo(stream);
            }
            return path;

        }

        public static string WriteFilePerfil(IFormFile img, int user_Id, string user_name)
        {
            string caminhoCompleto = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images", user_Id + "_" + user_name.ToString());

            if (!Directory.Exists(caminhoCompleto))
            {
                Directory.CreateDirectory(caminhoCompleto);
            }

            string fileName = "Perfil";
            string path = Path.Combine(caminhoCompleto, fileName + System.IO.Path.GetExtension(img.FileName));
            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                img.CopyTo(stream);
            }
            return path;

        }
        private static string GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }
    }
}
