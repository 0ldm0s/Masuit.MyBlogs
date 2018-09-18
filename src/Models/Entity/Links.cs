using Models.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entity
{
    /// <summary>
    /// ��������
    /// </summary>
    [Table("Links")]
    public class Links : BaseEntity
    {
        public Links()
        {
            Status = Status.Available;
            Except = false;
        }

        /// <summary>
        /// ����
        /// </summary>
        [Required(ErrorMessage = "վ��������Ϊ�գ�")]
        public string Name { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [Required(ErrorMessage = "վ���URL����Ϊ�գ�")]
        public string Url { get; set; }

        /// <summary>
        /// �Ƿ��������
        /// </summary>
        public bool Except { get; set; }
    }
}