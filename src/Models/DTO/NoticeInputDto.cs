using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Entity;
using Models.Enum;
using Models.Validation;

namespace Models.DTO
{
    /// <summary>
    /// ��վ��������ģ��
    /// </summary>
    public class NoticeInputDto : BaseEntity
    {
        public NoticeInputDto()
        {
            PostDate = DateTime.Now;
            ModifyDate = DateTime.Now;
            Status = Status.Display;
        }

        /// <summary>
        /// ����
        /// </summary>
        [Required(ErrorMessage = "������ⲻ��Ϊ�գ�"), MaxLength(64, ErrorMessage = "��������64���ַ���"), MinLength(2, ErrorMessage = "�����������2���ַ�")]
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
    }
}