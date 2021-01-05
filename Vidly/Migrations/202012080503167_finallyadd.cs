namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finallyadd : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'f66582e2-77ff-4fbb-a91d-9ac67be68bb1', N'admin@Mserver.com', 0, N'ADhHv60B4UCFPf/xZMFMQR5qQ7awfdysGB82aT57iDi6jcPVdcenCE+FGR+64SNGug==', N'254ac523-1aee-4031-a38c-eed0a70e4ec2', NULL, 0, 0, NULL, 1, 0, N'admin@Mserver.com', N'442280', N'01840772225')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b38fafbd-3156-440a-88ab-851b2433fefc', N'guest@vidly.com', 0, N'AAW9NIqUYk2fzp4xEofrNRiTM0FFUYrdZvL86YXBk4OVCjikqSAWUQytHgek+Cl4yA==', N'bb97d846-7e91-4b40-a1cd-94e996ffa47c', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'df696c9b-fa26-4f46-b2b1-ad753ea50361', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f66582e2-77ff-4fbb-a91d-9ac67be68bb1', N'df696c9b-fa26-4f46-b2b1-ad753ea50361')
");
        }
        
        public override void Down()
        {
        }
    }
}
