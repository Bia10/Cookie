//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Party
{
    using Cookie.API.Utils.IO;


    public class PartyNameSetErrorMessage : AbstractPartyMessage
    {
        
        public new const uint ProtocolId = 6501;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_result;
        
        public virtual byte Result
        {
            get
            {
                return m_result;
            }
            set
            {
                m_result = value;
            }
        }
        
        public PartyNameSetErrorMessage(byte result)
        {
            m_result = result;
        }
        
        public PartyNameSetErrorMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_result);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_result = reader.ReadByte();
        }
    }
}
