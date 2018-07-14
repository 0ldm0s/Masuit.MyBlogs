using System;
using Models.Entity;
using Models.Enum;
using Models.Validation;

namespace Models.DTO
{
    /// <summary>
    /// �ÿͶ��ı�
    /// </summary>
    public class BroadcastInputDto : BaseEntity
    {
        public BroadcastInputDto()
        {
            Status = Status.Subscribing;
            UpdateTime = DateTime.Now;
        }

        /// <summary>
        /// ���Ľ�������
        /// </summary>
        [IsEmail]
        public string Email { get; set; }

        /// <summary>
        /// ��֤��
        /// </summary>
        public string ValidateCode { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public SubscribeType SubscribeType { get; set; }
    }
}