using Masuit.MyBlogs.Core.Models.Enum;
using Masuit.MyBlogs.Core.Models.Validation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Masuit.MyBlogs.Core.Models.Entity
{
    /// <summary>
    /// ����
    /// </summary>
    [Table("Post")]
    public class Post : BaseEntity
    {
        public Post()
        {
            Comment = new HashSet<Comment>();
            PostDate = DateTime.Now;
            ModifyDate = DateTime.Now;
            IsFixedTop = false;
            Status = Status.Pending;
            IsWordDocument = false;
            Seminar = new HashSet<SeminarPost>();
            PostAccessRecord = new HashSet<PostAccessRecord>();
        }

        /// <summary>
        /// ����
        /// </summary>
        [Required(ErrorMessage = "���±��ⲻ��Ϊ�գ�")]
        public string Title { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Required, MaxLength(24, ErrorMessage = "�������֧��24���ַ���")]
        public string Author { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Required(ErrorMessage = "�������ݲ���Ϊ�գ�"), SubmitCheck(20, 1000000, false)]
        public string Content { get; set; }

        /// <summary>
        /// �ܱ���������
        /// </summary>
        public string ProtectContent { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime PostDate { get; set; }

        /// <summary>
        /// �޸�ʱ��
        /// </summary>
        public DateTime ModifyDate { get; set; }

        /// <summary>
        /// �Ƿ��ö�
        /// </summary>
        [DefaultValue(false)]
        public bool IsFixedTop { get; set; }

        /// <summary>
        /// ����id
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// ��Դ��
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// �Ƿ���Word�ĵ�
        /// </summary>
        [DefaultValue(false)]
        public bool IsWordDocument { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Required(ErrorMessage = "�������䲻��Ϊ�գ�"), IsEmail]
        public string Email { get; set; }

        /// <summary>
        /// ��ǩ
        /// </summary>
        [StringLength(256, ErrorMessage = "��ǩ�������255���ַ�")]
        public string Label { get; set; }

        /// <summary>
        /// ���¹ؼ���
        /// </summary>
        [StringLength(256, ErrorMessage = "���¹ؼ����������255���ַ�")]
        public string Keyword { get; set; }

        /// <summary>
        /// ֧����
        /// </summary>
        [DefaultValue(0)]
        public int VoteUpCount { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Computed), DefaultValue(0)]
        public int VoteDownCount { get; set; }

        /// <summary>
        /// �Ƿ���ͷͼ����
        /// </summary>
        [Required]
        [DefaultValue(false)]
        public bool IsBanner { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// ͼƬ��ַ
        /// </summary>
        [StringLength(255)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public virtual Category Category { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public virtual ICollection<Comment> Comment { get; set; }

        /// <summary>
        /// ר��
        /// </summary>
        public virtual ICollection<SeminarPost> Seminar { get; set; }

        /// <summary>
        /// �����¼
        /// </summary>
        public virtual ICollection<PostAccessRecord> PostAccessRecord { get; set; }

        /// <summary>
        /// ������ʷ�汾
        /// </summary>
        public virtual ICollection<PostHistoryVersion> PostHistoryVersion { get; set; }
    }
}