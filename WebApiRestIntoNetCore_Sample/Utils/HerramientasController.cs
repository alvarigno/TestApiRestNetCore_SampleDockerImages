using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiRestIntoNetCore_Sample.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiRestIntoNetCore_Sample.Utils
{

    public class Herramientas
    {

        public static string CreaDataContext()
        {

            string cglobal = "";
            cglobal = CredencialesGlobales.AppSetting["ConnectionStrings:BaseProdEntitiesSet"];
            return cglobal;

        }

    }

}
