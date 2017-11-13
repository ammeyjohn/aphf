using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APHF.Models
{
    /// <summary>
    /// 定义审计日志对象
    /// </summary>
    public class Audit
    {
        /// <summary>
        /// 获取或设置审计日志编号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 获取或设置IP地址
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// 获取或设置URL地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 获取或设置审计日志内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 获取或设置审计日志详细内容
        /// </summary>
        public object Detail { get; set; }

        /// <summary>
        /// 获取或设置相关用户编号
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 获取或设置审计日志创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
