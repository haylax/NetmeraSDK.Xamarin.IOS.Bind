using System;
using ObjCRuntime;
namespace NetmeraSDK.Xamarin.IOS.Bind
{
    [Native]
    public enum NetmeraProfileAttributeGender : ulong
    {
        Female = 1,
        Male = 0,
        NotSpecified = 2
    }

    [Native]
    public enum NetmeraProfileAttributeMaritalStatus : ulong
    {
        Single = 0,
        Married = 1,
        NotSpecified = 2
    }

    [Native]
    public enum NetmeraPushType : ulong
    {
        Standard = 1,
        Interactive = 2,
        Popup = 3,
        Silent = 6,
        Ping = 7,
        ConfigUpdate = 8,
        InAppMessage = 10
    }

    [Native]
    public enum NetmeraInboxStatus : ulong
    {
        Read = 1 << 0,
        Unread = 1 << 1,
        Deleted = 1 << 2,
        All = Read | Unread | Deleted
    }

    [Native]
    public enum NetmeraLogLevel : long
    {
        None = 0,
        Error = 1,
        Debug = 2
    }

    [Native]
    public enum NetmeraEventContentType : ulong
    {
        Other = 0,
        Image = 1,
        Audio = 2,
        Video = 3,
        Text = 4
    }
}