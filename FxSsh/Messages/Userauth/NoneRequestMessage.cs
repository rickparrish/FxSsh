using System;
using System.Linq;
using System.Text;

namespace FxSsh.Messages.Userauth
{
    public class NoneRequestMessage : RequestMessage
    {
        protected override void OnLoad(SshDataWorker reader)
        {
            base.OnLoad(reader);

            if (MethodName != "none")
                throw new ArgumentException(string.Format("Method name {0} is not valid.", MethodName));

            // NB: putty sends a different byte each time, can't find any details of what a "none" request should look like
            // so I'm not sure whether this should be read or not
            var unknown = reader.ReadByte(); 
        }
    }
}
