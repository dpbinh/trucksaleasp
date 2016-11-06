using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace TruckSaleWebApp.Utils
{
    public class FileHelper
    {
        public static string UploadFile(HttpPostedFile file, string path)
        {
            string filename = file.FileName;
            string ext = Path.GetExtension(filename);
            string newname = DateTime.Now.Ticks + ext;
            string newPath = Path.Combine( path, newname);
            string savePath = MapPath(newPath);
            file.SaveAs(savePath);
            return newPath;
        }

        public static void Delete(string oldImgPath)
        {
            File.Delete(MapPath(oldImgPath));
        }

        public static string MapPath(string path)
        {
            return HttpContext.Current.Server.MapPath("~" + path);
        }
    }
}