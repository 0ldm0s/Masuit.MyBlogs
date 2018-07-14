using System.ComponentModel.DataAnnotations;
using Models.Entity;
using Models.Enum;

namespace Models.DTO
{
    /// <summary>
    /// ��������
    /// </summary>
    public class LinksInputDto : BaseEntity
    {
        public LinksInputDto()
        {
            Status = Status.Available;
            Except = false;
        }

        /// <summary>
        /// ����
        /// </summary>
        [Required(ErrorMessage = "վ��������Ϊ�գ�"), MaxLength(16, ErrorMessage = "վ�������ֻ����16���ַ���"), MinLength(2, ErrorMessage = "վ����������2����")]
        public string Name { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [Required(ErrorMessage = "վ���URL����Ϊ�գ�"), StringLength(256, ErrorMessage = "URL�֧��256���ַ���")]
        public string Url { get; set; }

        /// <summary>
        /// �Ƿ��������
        /// </summary>
        public bool Except { get; set; }
    }
}