
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using Newtonsoft.Json;

using crmvcsb.Infrastructure.EF;
using crmvcsb.Infrastructure.EF.newOrder;
using crmvcsb.Domain.Interfaces;
using AutoMapper;
using crmvcsb.Domain.NewOrder.API;

using crmvcsb.Domain.NewOrder;


namespace crmvcsb.API.Areas.TestArea.FolderControllers
{
    [Route("api/Currency")]
    public class NewOrderController : Controller
    {

        private INewOrdermanager _manager;

        public NewOrderController(INewOrdermanager manager) {
            _manager = manager;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> GetCurrency(GetCurrencyCommand command){
            try{
                var result =  await _manager.GetCurrencyCrossRates(command);
                return Ok(result);
            }catch(Exception e){
                return BadRequest();
            }
        }

        [HttpGet("GetNoParam")]
        public async Task<IActionResult> GetCurrencyNoParam()
        {
            return Ok(null);
        }
        
    }
}