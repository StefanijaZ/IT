namespace OglasnikItProekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Avtomobils",
                c => new
                    {
                        AvtomobilID = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Lokacija = c.String(),
                        Cena = c.Int(nullable: false),
                        Opis = c.String(),
                    })
                .PrimaryKey(t => t.AvtomobilID);
            
            CreateTable(
                "dbo.Laptops",
                c => new
                    {
                        LaptopID = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Lokacija = c.String(),
                        Cena = c.Int(nullable: false),
                        Opis = c.String(),
                    })
                .PrimaryKey(t => t.LaptopID);
            
            CreateTable(
                "dbo.Mebels",
                c => new
                    {
                        MebelID = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Lokacija = c.String(),
                        Cena = c.Int(nullable: false),
                        Opis = c.String(),
                    })
                .PrimaryKey(t => t.MebelID);
            
            CreateTable(
                "dbo.Mobilens",
                c => new
                    {
                        MobilenID = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Lokacija = c.String(),
                        Cena = c.Int(nullable: false),
                        Opis = c.String(),
                    })
                .PrimaryKey(t => t.MobilenID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.BelaTehnikas",
                c => new
                    {
                        BelaTehnikaID = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Lokacija = c.String(),
                        Cena = c.Int(nullable: false),
                        Opis = c.String(),
                    })
                .PrimaryKey(t => t.BelaTehnikaID);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Zivealistes",
                c => new
                    {
                        ZivealisteID = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Lokacija = c.String(),
                        Cena = c.Int(nullable: false),
                        Opis = c.String(),
                    })
                .PrimaryKey(t => t.ZivealisteID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.Zivealistes");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.BelaTehnikas");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Mobilens");
            DropTable("dbo.Mebels");
            DropTable("dbo.Laptops");
            DropTable("dbo.Avtomobils");
        }
    }
}
