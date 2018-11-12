using System;
using Materal.TTA.Common;

namespace XYMS.Auth.Domain
{
    public class Account : IEntity<int>
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string ShaPassHash { get; set; }

        /// <summary>
        /// 会话键
        /// </summary>
        public string SessionKey { get; set; } = string.Empty;

        /// <summary>
        /// 未知
        /// </summary>
        public string V { get; set; } = string.Empty;

        /// <summary>
        /// 未知
        /// </summary>
        public string S { get; set; } = string.Empty;

        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 注册日期
        /// </summary>
        public DateTime Joindate { get; set; } = DateTime.Now;

        /// <summary>
        /// 最后登录IP
        /// </summary>
        public string LastIP { get; set; } = "127.0.0.1";

        /// <summary>
        /// 登录失败次数
        /// </summary>
        public int FailedLogins { get; set; } = 0;

        /// <summary>
        /// 锁定
        /// </summary>
        public byte Locked { get; set; } = 0;

        /// <summary>
        /// 最后登录日期
        /// </summary>
        public DateTime LastLogin { get; set; } = DateTime.Now;

        /// <summary>
        /// 在线标识
        /// </summary>
        public byte Online { get; set; } = 0;

        /// <summary>
        /// 扩展
        /// </summary>
        public byte Expansion { get; set; } = 2;

        /// <summary>
        /// 禁言时间
        /// </summary>
        public long MuteTime { get; set; } = 0;

        /// <summary>
        /// 禁言的原因
        /// </summary>
        public string MuteReason { get; set; } = string.Empty;

        /// <summary>
        /// 禁言
        /// </summary>
        public string MuteBy { get; set; } = string.Empty;

        /// <summary>
        /// 语言
        /// </summary>
        public byte Locale { get; set; } = 0;

        /// <summary>
        /// 操作系统
        /// </summary>
        public string OS { get; set; } = "Win";

        /// <summary>
        /// 招聘
        /// </summary>
        public int Recruiter { get; set; } = 0;
    }
}
