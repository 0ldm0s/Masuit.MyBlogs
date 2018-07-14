using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entity
{
    /// <summary>
    /// �ÿ��������
    /// </summary>
    [Table("InterviewDetail")]
    public class InterviewDetail
    {
        public InterviewDetail()
        {
            Time = DateTime.Now;
        }

        /// <summary>
        /// ����
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// ���ʹ���ҳ��
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// �����ķÿͱ�ID
        /// </summary>
        [ForeignKey("Interview")]
        public long InterviewId { get; set; }

        public virtual Interview Interview { get; set; }
    }
}