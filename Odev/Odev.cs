using System.Web;  
using System.Web.Mvc;  
using CreatingJsonFile.Models;  
using System.Web.Script.Serialization;
using System.IO; 
using Newtonsoft.Json; 
namespace CreatingJsonFile.Controllers  
{  
    public class ReadJsonController: Controller  
    {  
         
        public ActionResult Odev()  
        {

 List<RootObject> objects = File.ReadAllLines("Ogrenci.json","Personel.json","Idari.json","Derstanım.json","Ogrencipersonel.json)
                .Select(line => JsonConvert.DeserializeObject<RootObject>(line))
                .ToList();
             
            string Json = System.IO.File.ReadAllText(file);  
            JavaScriptSerializer ser = new JavaScriptSerializer();  
            var personlist = ser.Deserialize < List < Person >> (Json);  
            return View(personlist);  
        }  
    }  
} 