using FluentMigrator;

namespace NotifSystem.Migrations.DefaultDB
{
    [Migration(20200216191801)]
    public class DefaultDB_20200216_191801_notification_table : Migration
    {
        public override void Up()
        {
            Execute.Sql(@"
                CREATE TABLE [dbo].[Notification](  
                    [Id] [int] IDENTITY(1,1) NOT NULL,  
                    [Type] [int] NULL,  
                    [Details] [nvarchar](500) NULL,  
                    [Title] [nvarchar](50) NULL,  
                    [DetailsURL] [nvarchar](500) NULL,  
                    [SentTo] [nvarchar](50) NULL,  
                    [Date] [date] NULL,  
                    [IsRead] [bit] NULL,  
                    [IsDeleted] [bit] NULL,  
                    [IsReminder] [bit] NULL,  
                    [Code] [nvarchar](100) NULL,  
                    [NotificationType] [nvarchar](100) NULL,  
                 CONSTRAINT [PK_Notification] PRIMARY KEY CLUSTERED   
                (  
                    [Id] ASC  
                )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  
                ) ON [PRIMARY]  
                GO
            ");
        }

        public override void Down()
        {
            throw new System.NotImplementedException();
        }
    }
}