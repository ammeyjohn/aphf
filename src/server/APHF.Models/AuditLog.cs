using System;

namespace APHF.Models {
    /// <summary>
    /// 定义审计日志
    /// </summary>
    public class AuditLog {

        /// <summary>
        /// 获取或设置IP地址
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// 获取或设置URL地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 获取或设置日志内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 获取或设置日志详细内容
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// 获取或设置日志记录时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}