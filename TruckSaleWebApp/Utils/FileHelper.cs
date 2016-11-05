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
            string savePath = HttpContext.Current.Server.MapPath("~" + newPath);
            file.SaveAs(savePath);
            return newPath;
        }
    }
}