using System;

namespace Models.DTO
{
    /// <summary>
    /// �ÿ���Ϣ���ģ��
    /// </summary>
    public class InterviewOutputDto
    {
        public long Id { get; set; }

        /// <summary>
        /// IP��ַ
        /// </summary>
        public string IP { get; set; }

        /// <summary>
        /// UA
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// ����ϵͳ�汾
        /// </summary>
        public string OperatingSystem { get; set; }

        /// <summary>
        /// ������汾
        /// </summary>
        public string BrowserType { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime ViewTime { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string FromUrl { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// ʡ
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// ISP
        /// </summary>
        public string ISP { get; set; }

        /// <summary>
        /// ����ʽ
        /// </summary>
        public string HttpMethod { get; set; }

        /// <summary>
        /// ��ϸ����λ��
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// �ο�����λ��
        /// </summary>
        public string ReferenceAddress { get; set; }

        /// <summary>
        /// ��½ҳ
        /// </summary>
        public string LandPage { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string OnlineSpan { get; set; }
    }
}