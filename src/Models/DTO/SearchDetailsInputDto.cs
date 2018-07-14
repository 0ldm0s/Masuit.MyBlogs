using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DTO
{
    /// <summary>
    /// ������ϸ��¼����ģ��
    /// </summary>
    public class SearchDetailsInputDto
    {
        public SearchDetailsInputDto()
        {
            SearchTime = DateTime.Now;
        }

        /// <summary>
        /// �ؼ���
        /// </summary>
        [Required(ErrorMessage = "�ؼ��ʲ���Ϊ��"), MaxLength(64, ErrorMessage = "�ؼ����������64���ַ�")]
        public string KeyWords { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        [Column(TypeName = "datetime2")]
        public DateTime SearchTime { get; set; }

        /// <summary>
        /// ������IP
        /// </summary>
        public string IP { get; set; }
    }
}