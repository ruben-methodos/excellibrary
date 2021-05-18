﻿using System.IO;

namespace ExcelLibrary.BinaryFileFormat
{
	public partial class SubRecord
	{
		public static new SubRecord Read(Stream stream)
		{
			SubRecord record = SubRecord.ReadBase(stream);
			switch (record.Type)
			{
				case SubRecordType.CommonObjectData:
					return new CommonObjectData(record);
				case SubRecordType.End:
					return new End(record);
				case SubRecordType.GroupMarker:
					return new GroupMarker(record);
				case SubRecordType.ClipboardFormat:
					return new ClipboardFormat(record);
				case SubRecordType.PictureOption:
					return new PictureOption(record);
				default:
					return record;
			}
		}

	}
}
