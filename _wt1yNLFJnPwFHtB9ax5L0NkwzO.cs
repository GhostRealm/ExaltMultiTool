using ExaltMultiTool.Proxy.Networking.Packets;

internal class _wt1yNLFJnPwFHtB9ax5L0NkwzO : Packet
{
	public string _WL2DOBxBuX9DARzf2KPoaJbgZiCb;

	public override PacketType pType => PacketType.TRADEREQUESTED;

	public override void readPacketData(PacketReader r)
	{
		_WL2DOBxBuX9DARzf2KPoaJbgZiCb = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_WL2DOBxBuX9DARzf2KPoaJbgZiCb);
	}
}
