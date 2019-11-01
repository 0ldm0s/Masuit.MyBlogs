using Masuit.MyBlogs.Core.Models.Entity;
using Masuit.MyBlogs.Core.Models.Enum;
using Masuit.MyBlogs.Core.Models.Validation;
using System.ComponentModel.DataAnnotations;

namespace Masuit.MyBlogs.Core.Models.DTO
{
    /// <summary>
    /// ����ҳ����ģ��
    /// </summary>
    public class MiscInputDto : BaseEntity
    {
        public MiscInputDto()
        {
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
    }
}