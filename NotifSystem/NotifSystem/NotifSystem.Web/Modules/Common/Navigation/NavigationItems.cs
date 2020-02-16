using Serenity.Navigation;
using Administration = NotifSystem.Administration.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]
[assembly: NavigationLink(2000, "Default/SimpleChat", typeof(NotifSystem.Default.Pages.SimpleChatController), icon: null)]
[assembly: NavigationLink(3000, "Default/DemoNotification", typeof(NotifSystem.Default.Pages.DemoNotificationController), icon: null)]

//[assembly: NavigationLink(int.MaxValue, "Default/Notification", typeof(MyPages.NotificationController), icon: null)]