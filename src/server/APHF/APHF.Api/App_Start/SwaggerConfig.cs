using Swashbuckle.Application;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Http;

namespace APHF.Api
{
    /// <summary>
    /// Swashbuckle组件配置
    /// https://github.com/domaindrivendev/Swashbuckle
    /// </summary>
    public class SwaggerConfig
    {
        /// <summary>
        /// 注册Swashbuckle组件配置
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            config
                .EnableSwagger("docs/{apiVersion}",
                    c => {
                        c.SingleApiVersion("v1", "APHF Api");
                        foreach (var path in GetXmlCommentsPath())
                            c.IncludeXmlComments(path);
                    })
                .EnableSwaggerUi("docs/ui/{*assetPath}");
        }

        /// <summary>
        /// 获取所有XML说明文件路径
        /// </summary>
        /// <returns>返回XML说明文件路径列表</returns>
        private static List<string> GetXmlCommentsPath()
        {
            List<string> path = new List<string>();
            string root = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin");
            path.AddRange(GetXmlCommentsPathFromDirectory(root));
            foreach (var directory in Directory.GetDirectories(root))
            {
                path.AddRange(GetXmlCommentsPathFromDirectory(root));
            }
            return path;
        }

        /// <summary>
        /// 从指定文件夹中获取XML说明文件路径
        /// </summary>
        /// <param name="directory">文件夹路径</param>
        /// <returns>返回XML说明文件路径列表</returns>
        private static IEnumerable<string> GetXmlCommentsPathFromDirectory(string directory)
        {
            List<string> path = new List<string>();
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, directory);
            if (Directory.Exists(fullPath))
            {
                foreach (var file in Directory.GetFiles(fullPath, "*.xml"))
                {
                    string fileName = Path.GetFileName(file);
                    if (fileName.StartsWith("APHF."))
                        path.Add(file);
                }
            }
            return path;
        }
    }
}