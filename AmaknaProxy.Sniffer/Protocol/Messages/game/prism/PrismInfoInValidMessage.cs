

// Generated on 04/03/2020 21:59:06
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PrismInfoInValidMessage : NetworkMessage
    {
        public const uint Id = 5859;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte reason;
        
        public PrismInfoInValidMessage()
        {
        }
        
        public PrismInfoInValidMessage(sbyte reason)
        {
            this.reason = reason;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(reason);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            reason = reader.ReadSbyte();
        }
        
    }
    
}