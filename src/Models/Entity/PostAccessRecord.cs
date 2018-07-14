using System;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Enum;

namespace Models.Entity
{
    /// <summary>
    /// ���·��ʼ�¼
    /// </summary>
    [Table("PostAccessRecord")]
    public partial class PostAccessRecord : BaseEntity
    {
        public PostAccessRecord()
        {
            Status = Status.Default;
        }

        [ForeignKey("Post")]
        public int PostId { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime AccessTime { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public int ClickCount { get; set; }

        public virtual Post Post { get; set; }
    }
}