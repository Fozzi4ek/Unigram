// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessageEntityItalic : TLMessageEntityBase 
	{
		public TLMessageEntityItalic() { }
		public TLMessageEntityItalic(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessageEntityItalic; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Offset = from.ReadInt32();
			Length = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x826F8B60);
			to.Write(Offset);
			to.Write(Length);
			if (cache) WriteToCache(to);
		}
	}
}