namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MembershipTypeAsString = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET MembershipTypeAsString = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET MembershipTypeAsString = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET MembershipTypeAsString = 'Annually' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
