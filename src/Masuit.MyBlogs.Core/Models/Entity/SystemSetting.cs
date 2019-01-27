using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Masuit.MyBlogs.Core.Models.Entity;
using Masuit.MyBlogs.Core.Models.Enum;

namespace Masuit.MyBlogs.Core.Models.Entity
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