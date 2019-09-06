using System.ComponentModel.DataAnnotations;
using Masuit.MyBlogs.Core.Models.Validation;

namespace Masuit.MyBlogs.Core.Models.DTO
{
    /// <summary>
    /// �����޸�����
    /// </summary>
    public class PostMergeRequestInputDtoBase : BaseDto
    {
        /// <summary>
        /// ����
        /// </summary>
        [Required(ErrorMessage = "���±��ⲻ��Ϊ�գ�"), MaxLength(128, ErrorMessage = "���±����֧��128���ַ���"), MinLength(4, ErrorMessage = "���±�������4���ַ���")]
        public string Title { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Required(ErrorMessage = "�������ݲ���Ϊ�գ�"), SubmitCheck(20, 1000000, false)]
        public string Content { get; set; }
    }
}