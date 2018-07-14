using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Entity;
using Models.Enum;
using Models.Validation;

namespace Models.DTO
{
    /// <summary>
    /// ����ҳ����ģ��
    /// </summary>
    public class MiscInputDto : BaseEntity
    {
        public MiscInputDto()
        {
            PostDate = DateTime.Now;
            ModifyDate = DateTime.Now;
            Status = Status.Display;
        }

        /// <summary>
        /// ����
        /// </summary>
        [Required(ErrorMessage = "���ⲻ��Ϊ�գ�"), MaxLength(64, ErrorMessage = "�����֧��64���ַ���"), MinLength(4, ErrorMessage = "��������4���ַ���")]
        public string Title { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Required(ErrorMessage = "���ݲ���Ϊ�գ�"), SubmitCheck(100000, false)]
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