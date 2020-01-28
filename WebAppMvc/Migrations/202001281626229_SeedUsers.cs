namespace WebAppMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'19a69894-d4fe-4836-bfe0-9e64f592d820', N'guest@shemile.com', 0, N'AHecHnc3g1wcWbSZiEy/v6E6LbosIvkcQcHDxNdzXae37ppxtBASzRYSI57YjZ29Gw==', N'ced85006-7365-4885-b7f8-163e306813aa', NULL, 0, 0, NULL, 1, 0, N'guest@shemile.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6669e15a-5312-41f5-9c59-e8f78b650785', N'admin@shemile.com', 0, N'AI10I1piXCVgBzOYTjzrWcjqzzp0iw1nuvBH5z49ZGkFQsYdsUKRc5JW+whuW9kFEw==', N'b51eb85e-91ad-4714-923c-3f09190dec07', NULL, 0, 0, NULL, 1, 0, N'admin@shemile.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bda0fe0a-3089-4eb9-8b46-b5a8d4e66289', N'CanManageMovies')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6669e15a-5312-41f5-9c59-e8f78b650785', N'bda0fe0a-3089-4eb9-8b46-b5a8d4e66289')


");
        }
        
        public override void Down()
        {
        }
    }
}
