using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace MmsTwilio {

    class Program {

        static void Main(string[] args) {


            // Find your Account Sid and Auth Token at twilio.com / user / account
            // To set up environmental variables, see http://twil.io/secure
            string accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
            string authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");

            string niftyImagesUrl = "";
            string twilioPhoneNumber = "";
            string twilioToNumber = "";

            // Initialize the Twilio client
            TwilioClient.Init(accountSid, authToken);

            // Send a new outgoing SMS by POSTing to the Messages resource
            var m = MessageResource.Create(
                from: new PhoneNumber(twilioPhoneNumber),
                to: new PhoneNumber(twilioToNumber),
                mediaUrl: new List<Uri>() { new Uri(niftyImagesUrl) }
            );

            Console.WriteLine("Test Successfully Sent");
            Console.ReadLine();

        }

    }
}
