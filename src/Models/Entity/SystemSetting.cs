using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Enum;

namespace Models.Entity
{
    /// <summary>
    /// ϵͳ����
    /// </summary>
    [Table("SystemSetting")]
    public class SystemSetting : BaseEntity
    {
        public SystemSetting()
        {
            Status = Status.Available;
        }
        /// <summary>
        /// ��������
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// ֵ
        /// </summary>
        [Required]
        public string Value { get; set; }

    }
}