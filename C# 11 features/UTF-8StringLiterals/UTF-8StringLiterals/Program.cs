﻿// https://twitter.com/okyrylchuk/status/1527377339520548865

using System.Text;

// byte[] array = Encoding.UTF8.GetBytes("Hello World"); // C# 10
ReadOnlySpan<byte> span = "Hello World"u8;
byte[] array = span.ToArray();

