using Masuit.Tools.DateTimeExt;
using Masuit.Tools.Security;
using Masuit.Tools.Win32;
using Models.Application;
using Models.Entity;
using Models.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;

namespace Models.Migrations
{
    /// <summary>
    /// ��������������
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            //�����Զ�Ǩ��
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(DataContext context)
        {
#if DEBUG

            #region ��ʼ����

            if (!context.SystemSetting.Any())
            {
                context.Database.ExecuteSqlCommand(@"if not exists(select * from sysindexes where id=object_id('Interview') and name='IX_ViewTime') 
                                                                    CREATE NONCLUSTERED INDEX [IX_ViewTime] ON [dbo].[Interview] ([ViewTime] DESC)");
                context.Database.ExecuteSqlCommand(@"if not exists(select * from sysindexes where id=object_id('Post') and name='IX_ModifyDate') 
                                                                    CREATE NONCLUSTERED INDEX [IX_ModifyDate] ON [dbo].[Post] ([ModifyDate] DESC)");
                context.Database.ExecuteSqlCommand(@"if not exists(select * from sysindexes where id=object_id('PostHistoryVersion') and name='IX_ModifyDate') 
                                                                    CREATE NONCLUSTERED INDEX [IX_ModifyDate] ON [dbo].[PostHistoryVersion] ([ModifyDate] DESC)");
                context.Database.ExecuteSqlCommand(@"if not exists(select * from sysindexes where id=object_id('InterviewDetail') and name='IX_InterviewId') 
                                                                    CREATE NONCLUSTERED INDEX [IX_InterviewId] ON [dbo].[InterviewDetail] ([InterviewId] ASC)");
                context.Database.ExecuteSqlCommand(@"if not exists(select * from sysindexes where id=object_id('SearchDetails') and name='IX_SearchTime') 
                                                                    CREATE NONCLUSTERED INDEX [IX_SearchTime] ON [dbo].[SearchDetails] ([SearchTime] DESC)");
                try
                {
                    #region ���Լ��

                    context.Database.ExecuteSqlCommand(@"ALTER TABLE [dbo].[Broadcast] ADD DEFAULT 0 FOR [IsSubscribe];
                                                                    ALTER TABLE [dbo].[Broadcast] ADD DEFAULT 0 FOR [IsDeleted];
                                                                    ALTER TABLE [dbo].[Broadcast] ADD DEFAULT 1 FOR [IsAvailable];
                                                                    ALTER TABLE [dbo].[Category] ADD DEFAULT 0 FOR [IsDeleted];
                                                                    ALTER TABLE [dbo].[Category] ADD DEFAULT 1 FOR [IsAvailable];
                                                                    ALTER TABLE [dbo].[Comment] ADD DEFAULT 0 FOR [IsPended];
                                                                    ALTER TABLE [dbo].[Comment] ADD DEFAULT 0 FOR [ParentId];
                                                                    ALTER TABLE [dbo].[Comment] ADD DEFAULT getdate() FOR [CommentDate];
                                                                    ALTER TABLE [dbo].[Comment] ADD DEFAULT 0 FOR [IsMaster];
                                                                    ALTER TABLE [dbo].[Comment] ADD DEFAULT 0 FOR [VoteCount];
                                                                    ALTER TABLE [dbo].[Comment] ADD DEFAULT 0 FOR [AgainstCount];
                                                                    ALTER TABLE [dbo].[Comment] ADD DEFAULT 0 FOR [IsDeleted];
                                                                    ALTER TABLE [dbo].[Comment] ADD DEFAULT 1 FOR [IsAvailable];
                                                                    ALTER TABLE [dbo].[Contacts] ADD DEFAULT 0 FOR [IsDeleted];
                                                                    ALTER TABLE [dbo].[Contacts] ADD DEFAULT 1 FOR [IsAvailable];
                                                                    ALTER TABLE [dbo].[Desktop] ADD DEFAULT 0 FOR [IsDeleted];
                                                                    ALTER TABLE [dbo].[Desktop] ADD DEFAULT 1 FOR [IsAvailable];
                                                                    ALTER TABLE [dbo].[Interview] ADD DEFAULT getdate() FOR [ViewTime];
                                                                    ALTER TABLE [dbo].[LeaveMessage] ADD DEFAULT getdate() FOR [PostDate];
                                                                    ALTER TABLE [dbo].[LeaveMessage] ADD DEFAULT 0 FOR [IsPended];
                                                                    ALTER TABLE [dbo].[LeaveMessage] ADD DEFAULT 0 FOR [ParentId];
                                                                    ALTER TABLE [dbo].[LeaveMessage] ADD DEFAULT 0 FOR [IsMaster];
                                                                    ALTER TABLE [dbo].[LeaveMessage] ADD DEFAULT 0 FOR [IsDeleted];
                                                                    ALTER TABLE [dbo].[LeaveMessage] ADD DEFAULT 1 FOR [IsAvailable];
                                                                    ALTER TABLE [dbo].[Links] ADD DEFAULT 0 FOR [IsDeleted];
                                                                    ALTER TABLE [dbo].[Links] ADD DEFAULT 1 FOR [IsAvailable];
                                                                    ALTER TABLE [dbo].[Menu] ADD DEFAULT 0 FOR [ParentId];
                                                                    ALTER TABLE [dbo].[Menu] ADD DEFAULT 0 FOR [IsDeleted];
                                                                    ALTER TABLE [dbo].[Menu] ADD DEFAULT 1 FOR [IsAvailable];
                                                                    ALTER TABLE [dbo].[Misc] ADD DEFAULT getdate() FOR [PostDate];
                                                                    ALTER TABLE [dbo].[Misc] ADD DEFAULT getdate() FOR [ModifyDate];
                                                                    ALTER TABLE [dbo].[Misc] ADD DEFAULT 0 FOR [IsDeleted];
                                                                    ALTER TABLE [dbo].[Misc] ADD DEFAULT 1 FOR [IsAvailable];
                                                                    ALTER TABLE [dbo].[Notice] ADD DEFAULT getdate() FOR [PostDate];
                                                                    ALTER TABLE [dbo].[Notice] ADD DEFAULT getdate() FOR [ModifyDate];
                                                                    ALTER TABLE [dbo].[Notice] ADD DEFAULT 0 FOR [IsDeleted];
                                                                    ALTER TABLE [dbo].[Notice] ADD DEFAULT 1 FOR [IsAvailable];
                                                                    ALTER TABLE [dbo].[Post] ADD DEFAULT 0 FOR [ViewCount];
                                                                    ALTER TABLE [dbo].[Post] ADD DEFAULT getdate() FOR [PostDate];
                                                                    ALTER TABLE [dbo].[Post] ADD DEFAULT getdate() FOR [ModifyDate];
                                                                    ALTER TABLE [dbo].[Post] ADD DEFAULT 0 FOR [IsFixedTop];
                                                                    ALTER TABLE [dbo].[Post] ADD DEFAULT 0 FOR [IsPended];
                                                                    ALTER TABLE [dbo].[Post] ADD DEFAULT 0 FOR [IsWordDocument];
                                                                    ALTER TABLE [dbo].[Post] ADD DEFAULT 0 FOR [VoteUpCount];
                                                                    ALTER TABLE [dbo].[Post] ADD DEFAULT 0 FOR [VoteDownCount];
                                                                    ALTER TABLE [dbo].[Post] ADD DEFAULT getdate() FOR [LastAccessTime];
                                                                    ALTER TABLE [dbo].[Post] ADD DEFAULT 0 FOR [IsDeleted];
                                                                    ALTER TABLE [dbo].[Post] ADD DEFAULT 1 FOR [IsAvailable];
                                                                    ALTER TABLE [dbo].[SearchDetails] ADD DEFAULT getdate() FOR [SearchTime];
                                                                    ALTER TABLE [dbo].[SystemSetting] ADD DEFAULT 0 FOR [IsDeleted];
                                                                    ALTER TABLE [dbo].[SystemSetting] ADD DEFAULT 1 FOR [IsAvailable];
                                                                    ALTER TABLE [dbo].[Top] ADD DEFAULT 1 FOR [IsDisplay];
                                                                    ALTER TABLE [dbo].[Top] ADD DEFAULT 0 FOR [IsDeleted];
                                                                    ALTER TABLE [dbo].[Top] ADD DEFAULT 1 FOR [IsAvailable];
                                                                    ALTER TABLE [dbo].[UserInfo] ADD DEFAULT 0 FOR [IsAdmin];
                                                                    ALTER TABLE [dbo].[UserInfo] ADD DEFAULT getdate() FOR [LastLogin];
                                                                    ALTER TABLE [dbo].[UserInfo] ADD DEFAULT 0 FOR [IsDeleted];
                                                                    ALTER TABLE [dbo].[UserInfo] ADD DEFAULT 1 FOR [IsAvailable];
                                                                ");

                    #endregion

                    #region �����洢����

                    context.Database.ExecuteSqlCommand(@"Create PROC [dbo].[sp_getChildrenCommentByParentId](@ParentId int)
                                                                    AS
                                                                    BEGIN    
                                                                        WITH Tree
                                                                            AS (SELECT * FROM Comment WHERE Id = @ParentId  --��һ����ѯ��Ϊ�ݹ�Ļ���(ê��)
                                                                                UNION ALL
                                                                                SELECT Comment.*     --�ڶ�����ѯ��Ϊ�ݹ��Ա�� ������Ա�Ľ��Ϊ��ʱ���˵ݹ������
                                                                                  FROM Tree INNER JOIN Comment ON Tree.Id = Comment.ParentId) 
                                                                            SELECT * FROM Tree   
                                                                    END
                                                                    ");
                    context.Database.ExecuteSqlCommand(@"Create PROC [dbo].[sp_getChildrenLeaveMsgByParentId](@ParentId int)
                                                                    AS
                                                                    BEGIN    
                                                                        WITH Tree
                                                                            AS (SELECT * FROM LeaveMessage WHERE Id = @ParentId  --��һ����ѯ��Ϊ�ݹ�Ļ���(ê��)
                                                                                UNION ALL
                                                                                SELECT LeaveMessage.*     --�ڶ�����ѯ��Ϊ�ݹ��Ա�� ������Ա�Ľ��Ϊ��ʱ���˵ݹ������
                                                                                  FROM Tree INNER JOIN LeaveMessage ON Tree.Id = LeaveMessage.ParentId) 
                                                                            SELECT * FROM Tree   
                                                                    END
                                                                    ");
                    context.Database.ExecuteSqlCommand(@"Create PROC [dbo].[sp_getInterviewsCurrentMonthDetailsByDays] (@recent INT) AS
                                                                    BEGIN
                                                                     SELECT
                                                                      DATEPART(DAY, ViewTime) AS vt,
                                                                      COUNT (ViewTime) AS [count]
                                                                     FROM
                                                                      [dbo].[Interview]
                                                                     WHERE
                                                                      DATEDIFF(DAY, ViewTime, GETDATE()) < @recent
                                                                     AND DATEPART(MONTH, ViewTime) = DATEPART(MONTH, GETDATE())
                                                                     GROUP BY
                                                                      DATEPART(DAY, ViewTime)
                                                                     ORDER BY
                                                                      vt
                                                                     END
                                                                    ");

                    #endregion
                }
                catch (SqlException)
                {
                }
                IList<SystemSetting> ssList = new List<SystemSetting>
                {
                    new SystemSetting { Name = "Domain", Value = "masuit.com" },
                    new SystemSetting { Name = "logo", Value = "/assets/images/logo.png" },
                    new SystemSetting { Name = "Title", Value = "�����ڿ�Ĳ���" },
                    new SystemSetting { Name = "Brand", Value = "�����������񣬴����ǻۡ�" },
                    new SystemSetting { Name = "EmailFrom", Value = "anduyi@163.com" },
                    new SystemSetting { Name = "EmailPwd", Value = "123456" },
                    new SystemSetting { Name = "SMTP", Value = "smtp.163.com" },
                    new SystemSetting { Name = "SmtpPort", Value = "587" },
                    new SystemSetting { Name = "ReceiveEmail", Value = "1170397736@qq.com" },
                    new SystemSetting { Name = "Slogan", Value = "�����ڿ죬ȫջ�����ߣ�������������" },
                    new SystemSetting { Name = "Keyword", Value = "�����ڿ�" },
                    new SystemSetting { Name = "Description", Value = "�����ڿ�" },
                    new SystemSetting { Name = "Donate", Value = "https://ww4.sinaimg.cn/large/87c01ec7gy1fsqnp79malj20q911qtbd.jpg" },
                    new SystemSetting { Name = "Copyright", Value = "�����ڿ�" },
                    new SystemSetting { Name = "ReservedName", Value = "�����ڿ�|system|admin|Administrator|root" },
                    new SystemSetting { Name = "Disclaimer", Value = "��������" },
                    new SystemSetting { Name = "DonateWechat", Value = "https://ww3.sinaimg.cn/large/87c01ec7gy1fsqnp6iaj4j20u715fjuc.jpg" },
                    new SystemSetting { Name = "DonateQQ", Value = "https://ww2.sinaimg.cn/large/87c01ec7gy1fsqnp77bktj20i30jxq42.jpg" },
                    new SystemSetting { Name = "DonateJingdong", Value = "https://ww4.sinaimg.cn/large/87c01ec7gy1fsqnp6uc00j20ng0nt75j.jpg" },
                    new SystemSetting { Name = "PathRoot", Value = "C:" },
                };
                context.SystemSetting.AddOrUpdate(s => s.Name, ssList.ToArray());
            }

            if (!context.Category.Any())
            {
                var catList = new List<Category>
                {
                    new Category { Name = "Ĭ�Ϸ���" },
                    new Category { Name = "����ϵͳ" },
                    new Category { Name = "��Դ����" },
                    new Category { Name = "Ӱ�Ӿ�Ʒ" },
                    new Category { Name = "�����̳�" },
                    new Category { Name = "���򿪷�" },
                    new Category { Name = "��������" },
                    new Category { Name = "��ѧ����" },
                    new Category { Name = "��ѧ��Դ" },
                    new Category { Name = "�����ֽ" },
                    new Category { Name = "������ά" },
                    new Category { Name = "���ݿ�" },
                    new Category { Name = "��������" },
                    new Category { Name = "����" },
                    new Category { Name = "��ɫ���" },
                    new Category { Name = "ר���о�" },
                    new Category { Name = "����Ӳ��" },
                    new Category { Name = "�������" },
                    new Category { Name = "�������̳�" },
                    new Category { Name = "���" },
                    new Category { Name = "������Դ" }
                };
                context.Category.AddOrUpdate(c => c.Name, catList.ToArray());
            }

            if (!context.Contacts.Any())
            {
                var contacts = new List<Contacts>
                {
                    new Contacts { Title = "��ѶQQ", Url = "http://wpa.qq.com/msgrd?v=3&uin=1170397736&site=qq&menu=yes" },
                    new Contacts { Title = "QQ�ռ�", Url = "http://user.qzone.qq.com/1170397736/infocenter" },
                    new Contacts { Title = "�ٶ���", Url = "http://pan.baidu.com/share/home?uk=3372842977" },
                    new Contacts { Title = "QQ����", Url = "http://mail.qq.com/cgi-bin/qm_share?t=qm_mailme&email=1170397736@qq.com" },
                    new Contacts { Title = "GitHub", Url = "https://github.com/ldqk" }
                };
                context.Contacts.AddOrUpdate(c => c.Title, contacts.ToArray());
            }

            if (!context.Links.Any())
            {
                var links = new List<Links>
                {
                    new Links { Name = "�����ڿ�Ĳ���", Url = "https://masuit.com" },
                    new Links { Name = "�����ڿ�ļ���", Url = "http://resume.masuit.com" },
                    new Links { Name = "github", Url = "https://github.com/ldqk" },
                    new Links { Name = "QQ�ռ�", Url = "http://user.qzone.qq.com/1170397736/infocenter" },
                    new Links { Name = "�ٶ���", Url = "http://yun.baidu.com/share/home?uk=3372842977" }
                };
                context.Links.AddOrUpdate(l => l.Name, links.ToArray());
            }

            if (!context.Menu.Any())
            {
                var menus = new List<Menu>
                {
                    new Menu { Name = "��ҳ", Url = "/", Sort = 10, MenuType = MenuType.MainMenu },
                    new Menu { Name = "����", Url = "/p", Sort = 15, MenuType = MenuType.MainMenu },
                    new Menu { Name = "����", Url = "#", Sort = 20, MenuType = MenuType.MainMenu },
                    new Menu { Name = "ר��", Url = "#", Sort = 30, MenuType = MenuType.MainMenu },
                    new Menu { Name = "�ڿƼ�", Url = "#", Sort = 40, MenuType = MenuType.MainMenu },
                    new Menu { Name = "Ͷ��", Url = "/post/publish", Sort = 50, MenuType = MenuType.MainMenu },
                    new Menu { Name = "���԰�", Url = "/msg", Sort = 60, MenuType = MenuType.MainMenu },
                    new Menu { Name = "����", Url = "/donate", Sort = 70, MenuType = MenuType.MainMenu },
                    new Menu { Name = "����", Url = "/about", Sort = 70, MenuType = MenuType.MainMenu },
                };
                context.Menu.AddOrUpdate(m => m.Name, menus.ToArray());
            }

            if (!context.UserInfo.Any())
            {
                var salt = $"{new Random().StrictNext()}{DateTime.Now.GetTotalMilliseconds()}".MDString2(Guid.NewGuid().ToString()).AESEncrypt();
                context.UserInfo.AddOrUpdate(u => u.Username, new UserInfo
                {
                    Username = "masuit",
                    Password = "123abc@#$".MDString3(salt),
                    SaltKey = salt,
                    IsAdmin = true,
                    Email = "admin@masuit.com",
                    QQorWechat = "admin@masuit.com",
                    NickName = "�����ڿ�"
                });
            }

            //if (!context.Interview.Any())
            //{
            //    context.Interview.Add(new Interview()
            //    {
            //        IP = "114.114.114.114",
            //        UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3205.2 Safari/537.36",
            //        OperatingSystem = "WinNT",
            //        BrowserType = "Chrome63",
            //        ViewTime = DateTime.Now,
            //        FromUrl = "http://member.webweb.com/cp/domainbind.asp",
            //        HttpMethod = "GET"
            //    });
            //}
            #endregion

            context.SaveChanges();
#endif
        }
    }
}