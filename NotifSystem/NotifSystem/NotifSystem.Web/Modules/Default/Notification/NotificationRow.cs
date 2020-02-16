
namespace NotifSystem.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Notification]")]
    [DisplayName("Notification"), InstanceName("Notification")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class NotificationRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Type")]
        public Int32? Type
        {
            get { return Fields.Type[this]; }
            set { Fields.Type[this] = value; }
        }

        [DisplayName("Details"), Size(500), QuickSearch]
        public String Details
        {
            get { return Fields.Details[this]; }
            set { Fields.Details[this] = value; }
        }

        [DisplayName("Title"), Size(50)]
        public String Title
        {
            get { return Fields.Title[this]; }
            set { Fields.Title[this] = value; }
        }

        [DisplayName("Details Url"), Column("DetailsURL"), Size(500)]
        public String DetailsUrl
        {
            get { return Fields.DetailsUrl[this]; }
            set { Fields.DetailsUrl[this] = value; }
        }

        [DisplayName("Sent To"), Size(50)]
        public String SentTo
        {
            get { return Fields.SentTo[this]; }
            set { Fields.SentTo[this] = value; }
        }

        [DisplayName("Date")]
        public DateTime? Date
        {
            get { return Fields.Date[this]; }
            set { Fields.Date[this] = value; }
        }

        [DisplayName("Is Read")]
        public Boolean? IsRead
        {
            get { return Fields.IsRead[this]; }
            set { Fields.IsRead[this] = value; }
        }

        [DisplayName("Is Deleted")]
        public Boolean? IsDeleted
        {
            get { return Fields.IsDeleted[this]; }
            set { Fields.IsDeleted[this] = value; }
        }

        [DisplayName("Is Reminder")]
        public Boolean? IsReminder
        {
            get { return Fields.IsReminder[this]; }
            set { Fields.IsReminder[this] = value; }
        }

        [DisplayName("Code"), Size(100)]
        public String Code
        {
            get { return Fields.Code[this]; }
            set { Fields.Code[this] = value; }
        }

        [DisplayName("Notification Type"), Size(100)]
        public String NotificationType
        {
            get { return Fields.NotificationType[this]; }
            set { Fields.NotificationType[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Details; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public NotificationRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field Type;
            public StringField Details;
            public StringField Title;
            public StringField DetailsUrl;
            public StringField SentTo;
            public DateTimeField Date;
            public BooleanField IsRead;
            public BooleanField IsDeleted;
            public BooleanField IsReminder;
            public StringField Code;
            public StringField NotificationType;
        }
    }
}
