using Android.Content;
using Android.Net.Wifi;
using Android.Telephony;
using Android.Text;
using Org.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    public static class Utility
    {
        public static string GetDeviceInfo(Context context)
        {
            try
            {
                JSONObject json = new JSONObject();
                TelephonyManager tm = (TelephonyManager)context.GetSystemService(Context.TelephonyService);
                string device_id = tm.DeviceId;
                WifiManager wifi = (WifiManager)context.GetSystemService(Context.WifiService);
                string mac = wifi.ConnectionInfo.MacAddress;
                json.Put("mac", mac);

                if (TextUtils.IsEmpty(device_id))
                {
                    device_id = mac;
                }

                if (TextUtils.IsEmpty(device_id))
                {
                    device_id = Android.Provider.Settings.Secure.GetString(context.ContentResolver, Android.Provider.Settings.Secure.AndroidId);
                }

                json.Put("device_id", device_id);

                return json.ToString();
            }
            catch (Exception e)
            {
                //e.PrintStackTrace();
            }
            return null;
        }
    }
}
