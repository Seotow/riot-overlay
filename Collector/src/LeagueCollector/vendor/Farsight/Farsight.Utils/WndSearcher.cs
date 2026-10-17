using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Farsight.Utils;

internal class WndSearcher
{
	private delegate bool EnumWindowsProc(nint hWnd, nint lParam);

	[Flags]
	private enum ProcessAccessFlags : uint
	{
		QueryLimitedInformation = 0x1000u
	}

	[LibraryImport("user32.dll")]
	[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "10.0.14.37416")]
	[SkipLocalsInit]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static bool EnumWindows(EnumWindowsProc lpEnumFunc, nint lParam)
	{
		int num = __PInvoke((lpEnumFunc != null) ? Marshal.GetFunctionPointerForDelegate(lpEnumFunc) : 0, lParam);
		GC.KeepAlive(lpEnumFunc);
		return num != 0;
		[DllImport("user32.dll", EntryPoint = "EnumWindows", ExactSpelling = true)]
		static extern int __PInvoke(nint __lpEnumFunc_native, nint __lParam_native);
	}

	[LibraryImport("user32.dll", SetLastError = true)]
	[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "10.0.14.37416")]
	[SkipLocalsInit]
	private unsafe static uint GetWindowThreadProcessId(nint hWnd, out uint lpdwProcessId)
	{
		lpdwProcessId = 0u;
		uint result;
		int lastSystemError;
		fixed (uint* _lpdwProcessId_native = &lpdwProcessId)
		{
			Marshal.SetLastSystemError(0);
			result = __PInvoke(hWnd, _lpdwProcessId_native);
			lastSystemError = Marshal.GetLastSystemError();
		}
		Marshal.SetLastPInvokeError(lastSystemError);
		return result;
		[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", ExactSpelling = true)]
		unsafe static extern uint __PInvoke(nint __hWnd_native, uint* __lpdwProcessId_native);
	}

	[LibraryImport("kernel32.dll", SetLastError = true)]
	[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "10.0.14.37416")]
	[SkipLocalsInit]
	private static nint OpenProcess(ProcessAccessFlags processAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, uint processId)
	{
		Marshal.SetLastSystemError(0);
		nint result = __PInvoke(processAccess, bInheritHandle ? 1 : 0, processId);
		Marshal.SetLastPInvokeError(Marshal.GetLastSystemError());
		return result;
		[DllImport("kernel32.dll", EntryPoint = "OpenProcess", ExactSpelling = true)]
		static extern nint __PInvoke(ProcessAccessFlags __processAccess_native, int __bInheritHandle_native, uint __processId_native);
	}

	[LibraryImport("kernel32.dll", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
	[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "10.0.14.37416")]
	[SkipLocalsInit]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static bool QueryFullProcessImageNameW(nint hProcess, uint dwFlags, [Out] char[] lpExeName, ref uint lpdwSize)
	{
		int num;
		int lastSystemError;
		fixed (uint* _lpdwSize_native = &lpdwSize)
		{
			fixed (char* ptr = &ArrayMarshaller<char, char>.ManagedToUnmanagedIn.GetPinnableReference(lpExeName))
			{
				void* _lpExeName_native = ptr;
				Marshal.SetLastSystemError(0);
				num = __PInvoke(hProcess, dwFlags, (char*)_lpExeName_native, _lpdwSize_native);
				lastSystemError = Marshal.GetLastSystemError();
			}
		}
		bool result = num != 0;
		Marshal.SetLastPInvokeError(lastSystemError);
		return result;
		[DllImport("kernel32.dll", EntryPoint = "QueryFullProcessImageNameW", ExactSpelling = true)]
		unsafe static extern int __PInvoke(nint __hProcess_native, uint __dwFlags_native, char* __lpExeName_native, uint* __lpdwSize_native);
	}

	[LibraryImport("kernel32.dll", SetLastError = true)]
	[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "10.0.14.37416")]
	[SkipLocalsInit]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static bool CloseHandle(nint hObject)
	{
		Marshal.SetLastSystemError(0);
		int num = __PInvoke(hObject);
		int lastSystemError = Marshal.GetLastSystemError();
		bool result = num != 0;
		Marshal.SetLastPInvokeError(lastSystemError);
		return result;
		[DllImport("kernel32.dll", EntryPoint = "CloseHandle", ExactSpelling = true)]
		static extern int __PInvoke(nint __hObject_native);
	}

	public static nint FindWindowByProcessName(string processName)
	{
		nint foundHwnd = IntPtr.Zero;
		GCHandle value = GCHandle.Alloc(processName);
		try
		{
			EnumWindows((nint hWnd, nint lParam) =>
			{
				string b = (string)GCHandle.FromIntPtr(lParam).Target;
				GetWindowThreadProcessId(hWnd, out var lpdwProcessId);
				if (lpdwProcessId == 0)
				{
					return true;
				}
				string processPathByPID = GetProcessPathByPID(lpdwProcessId);
				if (string.IsNullOrEmpty(processPathByPID))
				{
					return true;
				}
				if (string.Equals(Path.GetFileName(processPathByPID), b, StringComparison.OrdinalIgnoreCase))
				{
					foundHwnd = hWnd;
					return false;
				}
				return true;
			}, GCHandle.ToIntPtr(value));
		}
		finally
		{
			if (value.IsAllocated)
			{
				value.Free();
			}
		}
		return foundHwnd;
	}

	public static string? GetProcessPathByProcessName(string processName)
	{
		Process[] processesByName = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(processName));
		if (processesByName.Length == 0)
		{
			return null;
		}
		return GetProcessPathByPID((uint)processesByName[0].Id);
	}

	public static string? GetProcessPathByPID(uint processId)
	{
		nint num = OpenProcess(ProcessAccessFlags.QueryLimitedInformation, bInheritHandle: false, processId);
		if (num == IntPtr.Zero)
		{
			return null;
		}
		try
		{
			char[] array = new char[1024];
			uint lpdwSize = (uint)array.Length;
			if (QueryFullProcessImageNameW(num, 0u, array, ref lpdwSize))
			{
				return new string(array, 0, (int)lpdwSize);
			}
		}
		finally
		{
			CloseHandle(num);
		}
		return null;
	}
}
