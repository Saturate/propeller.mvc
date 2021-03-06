﻿using System.Web.Mvc;
using Newtonsoft.Json;
using Propeller.Mvc.Core.Processing;
using Propeller.Mvc.Demo.ViewModels;
using Sitecore.Mvc.Presentation;

namespace Propeller.Mvc.Demo.Controllers
{
    public class CharacterController : Controller
    {

        public ActionResult Index()
        {
            var mappingProcessor = new MappingProcessor();
            mappingProcessor.Process(null);


            var characterViewModel = new CharacterViewModel(RenderingContext.Current.Rendering);
            ViewBag.SerializedModel = JsonConvert.SerializeObject(characterViewModel, Formatting.Indented);
            return View(characterViewModel);
        }
    }
}