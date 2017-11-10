using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APHF.Models;
using Microsoft.AspNetCore.Mvc;

namespace APHF.Api.Controllers {
    /// <summary>
    /// 定义审计日志控制器
    /// </summary>
    [Route ("api/[controller]")]
    public class AuditController : Controller {

        [HttpPost]
        public async Task<bool> Post ([FromBody] AuditLog audit) {
            await Task.Delay(5000);
            return true;
        }
    }
}