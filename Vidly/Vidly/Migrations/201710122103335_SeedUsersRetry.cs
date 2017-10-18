namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsersRetry : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7034bcba-c51c-4be2-90a6-89bb9a00ecfa', N'admin2@vidly.com', 0, N'AJVcjREPai/pHrbZ3dhuB+124TgpDeyKV1qRKv3vNKwmBopbrkLmbOJWVUIk3D71lw==', N'30afe58a-e4e3-4311-85ff-dab0fe3514a3', NULL, 0, 0, NULL, 1, 0, N'admin2@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9a61753c-fa99-485d-a269-a39f561fe964', N'admin@vidly.com', 0, N'AIcctdeYAuP7fCwlP0ZmGfLySDT8PiQ1IGBPRipAhrSR+yTRXIhs6tO1C+sNcQD2tQ==', N'45c65ec8-9064-4a59-a711-4d64f186f75c', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b18bf30c-3c53-4dd7-b830-04b9e2a31fda', N'guest@vidly.com', 0, N'AOsvEYJwFGxBb4mUGJm4jtPZE8DLo73vulky97HiTkXy9BWco8WElTrEEMVlFtr7Xg==', N'086335cc-6dec-433f-8851-04359c61aecb', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e2867acd-700c-47e9-8a5c-bc7b4e4fd04d', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7034bcba-c51c-4be2-90a6-89bb9a00ecfa', N'e2867acd-700c-47e9-8a5c-bc7b4e4fd04d')
");
        }
        
        public override void Down()
        {
        }
    }
}
