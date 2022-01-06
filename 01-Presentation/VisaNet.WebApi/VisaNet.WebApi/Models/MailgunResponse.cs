﻿using System;

namespace VisaNet.WebApi.Models
{
    public class MailgunResponse
    {
        public string Event { get; set; }
        public string Recipient { get; set; }
        public string Domain { get; set; }
        public string MessageHeaders { get; set; }
        public string CustomVariables { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Token { get; set; }
        public string Signature { get; set; }
        public string MessageId { get; set; }
    }
}