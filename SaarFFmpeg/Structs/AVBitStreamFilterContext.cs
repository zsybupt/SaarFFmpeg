﻿using System;
using System.Runtime.InteropServices;
using Saar.FFmpeg.Enumerates;
using Saar.FFmpeg.Support;

namespace Saar.FFmpeg.Structs {
	[StructLayout(LayoutKind.Sequential)]
	unsafe public struct AVBitStreamFilterContext {
		public void* PrivData;
		public AVBitStreamFilter* Filter;
		public AVCodecParserContext* Parser;
		public AVBitStreamFilterContext* Next;
		public byte* Args;
	}
}