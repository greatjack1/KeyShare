using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeyShare.Models;
using Microsoft.AspNetCore.Mvc;

namespace KeyShare.Controllers
{
    public class KeysController : Controller
    {
        public IRepository mRepo;
        public KeysController(IRepository repo) {
            mRepo = repo;
        }
        // GET api/values
        [HttpGet]
        public JsonResult GetValue(string Key,string Secret)
        {
            try
            {
                return Json(mRepo.getValue(Key, Secret));
            }
            catch (Exception ex) {
                return Json("Error, try again later");
            }

            }

        [HttpGet]
        public JsonResult StoreValue(string Key,string Secret,string Value)
        {
            try
            {
                //create a new key entry and store it
                KeyEntry entry = new KeyEntry();
                entry.Key = Key;
                entry.Secret = Secret;
                entry.Value = Value;
                mRepo.addKeyEntry(entry);
                return Json("Success");
            }
            catch (Exception ex) {
                return Json("Error, try again later");
            }
        }
    }
}
