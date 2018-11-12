using System;

namespace XYMS.WPFCommon.Model
{
    /// <summary>
    /// 数据库配置模型
    /// </summary>
    [Serializable]
    public class DataBaseConfigModel
    {
        /// <summary>
        /// IP地址
        /// </summary>
        public string IP { get; set; }
        /// <summary>
        /// IP地址
        /// </summary>
        public string Port { get; set; }
        /// <summary>
        /// 账户
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 账号数据库名称
        /// </summary>
        public string AuthName { get; set; }
        /// <summary>
        /// 角色数据库名称
        /// </summary>
        public string CharacterName { get; set; }
        /// <summary>
        /// 世界数据库名称
        /// </summary>
        public string WorldName { get; set; }
    }
}
