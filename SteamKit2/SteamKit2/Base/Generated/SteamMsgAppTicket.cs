//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Option: light framework (CF/Silverlight) enabled
    
// Generated from: encrypted_app_ticket.proto
namespace SteamKit2.Internal
{
  [global::ProtoBuf.ProtoContract(Name=@"EncryptedAppTicket")]
  public partial class EncryptedAppTicket : global::ProtoBuf.IExtensible
  {
    public EncryptedAppTicket() {}
    

    private uint? _ticket_version_no;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ticket_version_no", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint ticket_version_no
    {
      get { return _ticket_version_no?? default(uint); }
      set { _ticket_version_no = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool ticket_version_noSpecified
    {
      get { return _ticket_version_no != null; }
      set { if (value == (_ticket_version_no== null)) _ticket_version_no = value ? this.ticket_version_no : (uint?)null; }
    }
    private bool ShouldSerializeticket_version_no() { return ticket_version_noSpecified; }
    private void Resetticket_version_no() { ticket_version_noSpecified = false; }
    

    private uint? _crc_encryptedticket;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"crc_encryptedticket", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint crc_encryptedticket
    {
      get { return _crc_encryptedticket?? default(uint); }
      set { _crc_encryptedticket = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool crc_encryptedticketSpecified
    {
      get { return _crc_encryptedticket != null; }
      set { if (value == (_crc_encryptedticket== null)) _crc_encryptedticket = value ? this.crc_encryptedticket : (uint?)null; }
    }
    private bool ShouldSerializecrc_encryptedticket() { return crc_encryptedticketSpecified; }
    private void Resetcrc_encryptedticket() { crc_encryptedticketSpecified = false; }
    

    private uint? _cb_encrypteduserdata;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"cb_encrypteduserdata", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint cb_encrypteduserdata
    {
      get { return _cb_encrypteduserdata?? default(uint); }
      set { _cb_encrypteduserdata = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool cb_encrypteduserdataSpecified
    {
      get { return _cb_encrypteduserdata != null; }
      set { if (value == (_cb_encrypteduserdata== null)) _cb_encrypteduserdata = value ? this.cb_encrypteduserdata : (uint?)null; }
    }
    private bool ShouldSerializecb_encrypteduserdata() { return cb_encrypteduserdataSpecified; }
    private void Resetcb_encrypteduserdata() { cb_encrypteduserdataSpecified = false; }
    

    private uint? _cb_encrypted_appownershipticket;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"cb_encrypted_appownershipticket", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint cb_encrypted_appownershipticket
    {
      get { return _cb_encrypted_appownershipticket?? default(uint); }
      set { _cb_encrypted_appownershipticket = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool cb_encrypted_appownershipticketSpecified
    {
      get { return _cb_encrypted_appownershipticket != null; }
      set { if (value == (_cb_encrypted_appownershipticket== null)) _cb_encrypted_appownershipticket = value ? this.cb_encrypted_appownershipticket : (uint?)null; }
    }
    private bool ShouldSerializecb_encrypted_appownershipticket() { return cb_encrypted_appownershipticketSpecified; }
    private void Resetcb_encrypted_appownershipticket() { cb_encrypted_appownershipticketSpecified = false; }
    

    private byte[] _encrypted_ticket;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"encrypted_ticket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] encrypted_ticket
    {
      get { return _encrypted_ticket?? null; }
      set { _encrypted_ticket = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool encrypted_ticketSpecified
    {
      get { return _encrypted_ticket != null; }
      set { if (value == (_encrypted_ticket== null)) _encrypted_ticket = value ? this.encrypted_ticket : (byte[])null; }
    }
    private bool ShouldSerializeencrypted_ticket() { return encrypted_ticketSpecified; }
    private void Resetencrypted_ticket() { encrypted_ticketSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
#pragma warning restore 1591
