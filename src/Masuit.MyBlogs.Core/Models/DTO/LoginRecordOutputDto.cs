using Masuit.MyBlogs.Core.Models.Enum;
using System;

namespace Masuit.MyBlogs.Core.Models.DTO
{
    /// <summary>
    /// �û���¼��¼���ģ��
    /// </summary>
    public class LoginRecordOutputDto : BaseDto
    {
        /// <summary>
        /// ��¼��IP
        /// </summary>
        public string IP { get; set; }

        /// <summary>
        /// ��¼ʱ��
        /// </summary>
        public DateTime LoginTime { get; set; }

        /// <summary>
        /// ����ʡ��
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// ��ϸ����λ��
        /// </summary>
        public string PhysicAddress { get; set; }

        /// <summary>
        /// ��¼����
        /// </summary>
        public LoginType LoginType { get; set; }

        /// <summary>
        /// ��½��ID
        /// </summary>
        public int UserInfoId { get; set; }
    }
}