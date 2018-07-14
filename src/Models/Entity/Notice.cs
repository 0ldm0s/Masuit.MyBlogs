using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Enum;
using Models.Validation;

namespace Models.Entity
{
    /// <summary>
    /// ��վ����
    /// </summary>
    [Table("Notice")]
    public class Notice : BaseEntity
    {
        public Notice()
        {
            PostDate = DateTime.Now;
            ModifyDate = DateTime.Now;
            Status = Status.Display;
        }

        /// <summary>
        /// ����
        /// </summary>
        [Required(ErrorMessage = "������ⲻ��Ϊ�գ�")]
        public string Title { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Required(ErrorMessage = "�������ݲ���Ϊ�գ�"), SubmitCheck(3000, false)]
        public string Content { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        [Column(TypeName = "datetime2")]
        public DateTime PostDate { get; set; }

        /// <summary>
        /// �޸�ʱ��
        /// </summary>
        [Column(TypeName = "datetime2")]
        public DateTime ModifyDate { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public int ViewCount { get; set; }
    }
}