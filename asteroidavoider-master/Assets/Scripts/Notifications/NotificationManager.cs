using Unity.Notifications.Android;
using UnityEngine;
using System.Collections;

public class NotificationManager : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(nameof(RequestNotificationPermission));

        var group = new AndroidNotificationChannelGroup()
        {
            Id = "Main",
            Name = "Main notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannelGroup(group);
        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.Default,
            Description = "Generic notifications",
            Group = "Main",  
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);

        ScheduleNotification();
    }

    private void ScheduleNotification()
    {
        var notification = new AndroidNotification();
        notification.Title = "Hello";
        notification.Text = "Play the game";
        notification.FireTime = System.DateTime.Now.AddMinutes(1);

        AndroidNotificationCenter.SendNotification(notification, "channel_id");
    }

    IEnumerator RequestNotificationPermission()
    {
        var request = new PermissionRequest();
        while (request.Status == PermissionStatus.RequestPending)
            yield return null;
    }

}
