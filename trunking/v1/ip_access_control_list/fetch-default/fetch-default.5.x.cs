// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using Twilio;
using Twilio.Rest.Trunking.V1.Trunk;


class Program 
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Token at twilio.com/console
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";

        TwilioClient.Init(accountSid, authToken);

        var ipAccessControlList = IpAccessControlListResource.Fetch(
            pathTrunkSid: "TRXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
            pathSid: "ALXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        );

        Console.WriteLine(ipAccessControlList.FriendlyName);
    }
}
