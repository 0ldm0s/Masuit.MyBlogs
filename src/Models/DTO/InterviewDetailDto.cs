using System;

namespace Models.DTO
{
    public class InterviewDetailDto
    {
        public InterviewDetailDto()
        {
            Time = DateTime.Now;
        }

        /// <summary>
        /// ���ʹ���ҳ��
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime Time { get; set; }
    }
}