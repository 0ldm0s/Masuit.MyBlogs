using System.ComponentModel.DataAnnotations;
using Models.Entity;
using Models.Enum;

namespace Models.DTO
{
    /// <summary>
    /// ��ϵ��ʽ����ģ��
    /// </summary>
    public class ContactsInputDto : BaseEntity
    {
        public ContactsInputDto()
        {
            Status = Status.Available;
        }

        /// <summary>
        /// ����
        /// </summary>
        [Required(ErrorMessage = "���ⲻ��Ϊ��"), MaxLength(255, ErrorMessage = "�����֧��255���ַ�"), MinLength(4, ErrorMessage = "��������4����")]
        public string Title { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [Required(ErrorMessage = "URL����Ϊ��"), MaxLength(255, ErrorMessage = "URL�֧��255���ַ�")]
        public string Url { get; set; }
    }
}