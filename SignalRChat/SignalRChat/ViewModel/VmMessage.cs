using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using SignalRChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Message = SignalRChat.Models.Message;

namespace SignalRChat.ViewModel
{
    public class VmMessage
    {
        public List<Message> Messages { get; set; }
        public CustomUser User { get; set; }
        public string SenderId { get; set; }
    }
}
