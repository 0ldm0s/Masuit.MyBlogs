using Masuit.MyBlogs.Core.Models.Entity;
using Masuit.MyBlogs.Core.Models.Enum;
using Masuit.MyBlogs.Core.Models.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace Masuit.MyBlogs.Core.Models.DTO
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
        public DateTime PostDate { get; set; }

        /// <summary>
        /// �޸�ʱ��
        /// </summary>
        public DateTime ModifyDate { get; set; }
    }
}