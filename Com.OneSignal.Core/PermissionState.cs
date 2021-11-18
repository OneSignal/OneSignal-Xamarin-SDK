using System;
using System.Collections.Generic;

namespace Com.OneSignal.Core {
    public class PermissionState {
        readonly bool hasPrompted = false;
        readonly bool provisional = false;
        NotificationPermission status;

        //public PermissionState(Dictionary<string, dynamic> json) {
        //    //if (json.ContainsKey("status")) {
        //    //    status = json["status"];

        //    //}
        //    //else if (json.ContainsKey("enabled")) {
        //    //    bool enabled = json["enabled"];
        //    //    status = enabled
        //    //       ? NotificationPermission.AUTHORIZED
        //    //       : NotificationPermission.DENIED;
        //    //}

        //    //    if (json.ContainsKey("provisional")) {
        //    //        provisional = json["provisional"];
        //    //    }
        //    //    else {
        //    //        provisional = false;
        //    //    }

        //    //    if (json.ContainsKey("hasPrompted")) {
        //    //        hasPrompted = json["hasPrompted"];
        //    //    }
        //    //    else {
        //    //        hasPrompted = false;
        //    //    }
        //    //}

        //    //public PermissionState(bool areNotificationsEnabled) {
        //    //    if (areNotificationsEnabled) {
        //    //        status = NotificationPermission.AUTHORIZED;
        //    //    }
        //    //    else {
        //    //        status = NotificationPermission.DENIED;
        //    //    }
        //}

        //string jsonRepresentation() {
        //    return "";
        //}        
    }

    public enum NotificationPermission { NOTDETERMINED, DENIED, AUTHORIZED, PROVISIONAL };
}
