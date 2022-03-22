using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Upload_Image_v2.Models;

namespace Upload_Image_v2.Controllers
{
    public class ImageController : Controller
    {
        MyContext db = new MyContext();




       [HttpGet]
       public ActionResult Index()
        {


            List<Image> images = db.Images.ToList();

            return View(images);
        }









        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }





        [HttpPost]
        public ActionResult Add(Image imageModel)
        {
            string filename = Path.GetFileNameWithoutExtension(imageModel.ImageFile.FileName);
            string extension = Path.GetExtension(imageModel.ImageFile.FileName);

            filename = filename + DateTime.Now.ToString("yymmssfff") + extension;

            imageModel.ImagePath = "~/Images/" + filename;
            filename = Path.Combine(Server.MapPath("~/Images/"), filename);
            imageModel.ImageFile.SaveAs(filename);

            db.Images.Add(imageModel);
            db.SaveChanges();



            List<Image> images = db.Images.ToList();

            return View("Index", images);
        }



        public ActionResult Delete(int id)
        {

            var image = db.Images.Find(id);
            db.Images.Remove(image);
            db.SaveChanges();


            List<Image> images = db.Images.ToList();
            return View("Index", images);

        }









    }
}