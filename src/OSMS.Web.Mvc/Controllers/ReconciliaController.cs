using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using OSMS.Controllers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Abp.Web.Models;
using System.Collections.Generic;
using System.IO;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Web;
using System.Globalization;
using OSMS.SellOrders.Dto;
using OSMS.SellOrders;
using OSMS.Web.Models.Reconcilia;
using System.Linq;

namespace OSMS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ReconciliaController : OSMSControllerBase
    {
        private readonly ISellOrderAppService _sellOrderAppService;

        public ReconciliaController(ISellOrderAppService sellOrderAppService)
        {
            _sellOrderAppService = sellOrderAppService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Import(IFormFile file)
        {
            List<T> list = new List<T> { };

            MemoryStream ms = new MemoryStream();
            file.CopyTo(ms);
            ms.Seek(0, SeekOrigin.Begin);

            IWorkbook workbook = new XSSFWorkbook(ms);
            ISheet sheet = workbook.GetSheetAt(0);

            var dtos = new List<SellOrderReconciliaModel>();
            var orders = await _sellOrderAppService.GetAll(new SellOrderDto());
            for (int i = 5; i <= sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);
                if (row.GetCell(0).ToString() == "")
                {
                    continue;
                }
                var dto = new SellOrderReconciliaModel
                {
                    TimeCreated=DateTime.Parse(row.GetCell(0).ToString()),
                    OrgName= row.GetCell(1).ToString(),
                    Station= row.GetCell(2).ToString(),
                    Product= row.GetCell(3).ToString(),
                    CompanyName = row.GetCell(4).ToString(),
                    CustomerName = row.GetCell(5).ToString(),
                    Count = decimal.Parse(row.GetCell(7).ToString()),
                    Price = decimal.Parse(row.GetCell(8).ToString()),
                    Amount = decimal.Parse(row.GetCell(9).ToString()),
                    Remaining = decimal.Parse(row.GetCell(10).ToString()),
                    Balance = decimal.Parse(row.GetCell(11).ToString()),
                    DriverName ="",
                    CardNo = ""
                };
                dto.Success = orders.Items.Where(c => c.TimeCreated == dto.TimeCreated && c.Count == dto.Count && c.Price == dto.Price && c.OrgName == dto.OrgName).Any();
                //await _sellOrderAppService.Create(dto);
                dtos.Add(dto);
            }
            return Json(new AjaxResponse { Result = dtos,Success=dtos.Where(c=>c.Success).Count()==dtos.Count });
        }

        public string UploadImageByBase64String(string file)
        {
            string result="";
            //图片路径
            var filePath = AppContext.BaseDirectory+"medias";
            try
            {
                byte[] bt = Convert.FromBase64String(file);//获取图片base64

                MemoryStream ms = new MemoryStream(bt);
                System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(ms);
                ms.Close();

                string fileName = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString();//年月
                string ImageFilePath = filePath + "/image" + "/" + fileName;
                if (!Directory.Exists(ImageFilePath))
                {
                    Directory.CreateDirectory(ImageFilePath);
                }
                string ImagePath = ImageFilePath + "/" + DateTime.Now.ToString("yyyyHHddHHmmss")+".png";//定义图片名称

                bmp.Save(ImagePath, System.Drawing.Imaging.ImageFormat.Png);//保存到服务器路径
                result = ImagePath;
            }
            catch (Exception e)
            {
                throw e;
            }
            return result;
        }

    }
}
