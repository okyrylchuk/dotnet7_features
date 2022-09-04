// https://twitter.com/okyrylchuk/status/1560355657517236226

using System.Runtime.InteropServices;

string str = "Hello!";

IntPtr intPtr = Marshal.StringToHGlobalAnsi(str);
nint nInt = Marshal.StringToHGlobalAnsi(str);

unsafe
{
    byte* src = (byte*)intPtr.ToPointer();
    byte* dst = (byte*)nInt.ToPointer();

}

