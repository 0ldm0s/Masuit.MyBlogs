using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Enum;

namespace Models.Entity
{
    /// <summary>
    /// ��ϵ��ʽ
    /// </summary>
    [Table("Contacts")]
    public class Contacts : BaseEntity
    {
        public Contacts()
        {
            Status = Status.Available;
        }

        /// <summary>
        /// ����
        /// </summary>
        [Required(ErrorMessage = "���ⲻ��Ϊ��")]
        public string Title { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [Required(ErrorMessage = "URL����Ϊ��")]
        public string Url { get; set; }
    }
}