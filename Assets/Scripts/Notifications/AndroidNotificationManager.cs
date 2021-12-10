using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.Android;

public class AndroidNotificationManager : MonoBehaviour
{
    private AndroidNotificationChannel androidChannel;
    private AndroidNotification notification;
    private int identifier;

    // Start is called before the first frame update
    void Start()
    {
        CreateChannel(androidChannel);
        SendNotification();
        if (AndroidNotificationCenter.CheckScheduledNotificationStatus(identifier) == NotificationStatus.Scheduled) 
        {
            AndroidNotificationCenter.CancelAllNotifications();
            AndroidNotificationCenter.SendNotification(notification, "channel_id");
        }
    }

    private void CreateChannel(AndroidNotificationChannel channel)
    {
        channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.Default,
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);
    }

    private void SendNotification()
    {
        
        notification = new AndroidNotification("Lets play!!", "You currently have:" + SaveManager._Instance.save.Coins.ToString() + " coins.", System.DateTime.Now.AddSeconds(20));
        //notification.Title;
        //notification.Text;
        //notification.FireTime;

        identifier = AndroidNotificationCenter.SendNotification(notification, "channel_id");
       
    }

}
