namespace WebAppMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedColumnsToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "SignUpFee", c => c.Short(nullable: false));
            AddColumn("dbo.MembershipTypes", "DurationInMonths", c => c.Byte(nullable: false));
            AddColumn("dbo.MembershipTypes", "DiscountRate", c => c.Byte(nullable: false));

            Sql("INSERT INTO MembershipTypes ( Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES(1,'PAY AS YOU GO',0,0,0) ");
            Sql("INSERT INTO MembershipTypes ( Id, Name,  SignUpFee, DurationInMonths, DiscountRate) VALUES(2,'MONTHLY',30,1,10) ");
            Sql("INSERT INTO MembershipTypes ( Id, Name,  SignUpFee, DurationInMonths, DiscountRate) VALUES(3,'QUARTERLY',90,3,15) ");
            Sql("INSERT INTO MembershipTypes ( id, Name,  SignUpFee, DurationInMonths, DiscountRate) VALUES(4,'ANUALLY',300,12,20) ");


        }

        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "DiscountRate");
            DropColumn("dbo.MembershipTypes", "DurationInMonths");
            DropColumn("dbo.MembershipTypes", "SignUpFee");
        }
    }
}
