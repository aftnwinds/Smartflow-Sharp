﻿/********************************************************************
 License: https://github.com/chengderen/Smartflow/blob/master/LICENSE 
 Home page: https://www.smartflow-sharp.com
 ********************************************************************
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;

namespace Smartflow
{
    internal class ResourceManage
    {
        /// <summary>
        /// 连接配置异常信息
        /// </summary>
        public const string CONNECTION_CONFIG = "CONNECTION_CONFIG";
        
        private static readonly ResourceManager resourceManage =new ResourceManager("Smartflow.SmartflowResource",Assembly.GetExecutingAssembly());
        
        public static string GetString(string key)
        {
            return resourceManage.GetString(key);
        }
    }
}
