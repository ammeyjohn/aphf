using APHF.Models;
using APHF.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace APHF.Api.Controllers
{
    /// <summary>
    /// 定义审计日志控制器
    /// </summary>
    [RoutePrefix(Consts.API_PRIFIX + "/audit")]
    public class AuditController : ApiController
    {
        /// <summary>
        /// 添加审计日志
        /// </summary>
        /// <param name="audit">审计日志对象</param>
        /// <returns>如果添加成功返回True，否则返回False</returns>
        public async Task<bool> Add([FromBody] Audit audit)
        {
            await Task.Delay(5000);
            return true;
        }
    }
}
