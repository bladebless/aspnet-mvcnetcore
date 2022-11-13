//Программы, игры и их исходные коды
//www.interestprograms.ru

using ASPMVC.Models;
using System.IO;
using System.Web.Mvc;

namespace ASPMVC.Controllers
{
    public class ColorsController : Controller
    {
        // GET: Colors
        public ActionResult Index()
        {
            //Colors colorsModel = new Colors();

            return View();
        }

        public ActionResult String()
        {
            Colors colorsModel = new Colors();

            return View(colorsModel);
        }


        // Метод обращения к части URL,
        // имя метода совпадает с частью пути
        // Например: domen.ru/Colors/List
        public ActionResult List()
        {
            Colors colorsModel = new Colors();
            
            return View(colorsModel);
        }

        // Метод обращения к части URL,
        // имя метода совпадает с частью пути
        // Например: domen.ru/Colors/Table
        public ActionResult Table()
        {
            Colors colorsModel = new Colors();

            return View(colorsModel);
        }

        public ActionResult File()
        {
            Colors colorsModel = new Colors();


            // Создадим файл в оперативной памяти
            // и отправим его по запросу пользователя
            MemoryStream ms = new MemoryStream();
            StreamWriter sw = new StreamWriter(ms);

            for (int i = 0; i < colorsModel.List.Length; i++)
            {
                sw.Write( (i+1).ToString() + ". " +  colorsModel.List[i] + "\r\n");
            }

            // Очищаем все занятые буфера и записываем  данные в основной поток
            sw.Flush();
            ms.Flush();

            // После всех операций указатель потока устанавливаем на начало.
            sw.BaseStream.Position = 0;

            // Отправляем созданный файл согласно запросу пользователя.
            return File(sw.BaseStream, "text/html", "Цвета.txt");
        }
    }
}