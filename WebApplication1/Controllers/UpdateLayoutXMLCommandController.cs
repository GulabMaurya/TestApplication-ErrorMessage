using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UpdateLayoutXMLCommandController : Controller
    {
        // GET: UpdateLayoutXMLCommand
        public ActionResult UpdateLayoutXMLCommand(Migration _UpdateLayoutXMLCommand)
        {
            /*Start copying from here Deepika Keep it first line*/
            UpdateLayoutXMLCommand xmlUpdateCmd = new UpdateLayoutXMLCommand();
            xmlUpdateCmd.CustomErrorMessage = _UpdateLayoutXMLCommand.CustomErrorMessage;
            /*End here Deepika*/

            return View(xmlUpdateCmd); //At this last line at the place of Return View
        }
        
        public ActionResult LayoutXMLDownload(string RadioInput, string selectedLayoutIdValue, string selectedRoleIdValue, string selectedLayoutTypeIDValue)
        {
            try {
                //your own code; Dummy Just to test; don;t copy 
                int a = 10;
                int b = 0;
                int c = a / b;

                return Json(new { fileName = "fileName, fileContent = fileContentBase64 "}); //Don't copy anything from try block

            }
            catch (Exception ex)
            {
                /*Start copying from here Deepika*/
                Migration   _migration = new Migration();
                _migration.CustomErrorMessage = ex.Message;
                return RedirectToAction("UpdateLayoutXMLCommand", _migration);
                /*End here Deepika*/
            }


        }
    }
}