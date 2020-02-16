
namespace NotifSystem.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Notification")]
    [BasedOnRow(typeof(Entities.NotificationRow), CheckNames = true)]
    public class NotificationForm
    {
        public Int32 Type { get; set; }
        public String Details { get; set; }
        public String Title { get; set; }
        public String DetailsUrl { get; set; }
        public String SentTo { get; set; }
        public DateTime Date { get; set; }
        public Boolean IsRead { get; set; }
        public Boolean IsDeleted { get; set; }
        public Boolean IsReminder { get; set; }
        public String Code { get; set; }
        public String NotificationType { get; set; }
    }
}