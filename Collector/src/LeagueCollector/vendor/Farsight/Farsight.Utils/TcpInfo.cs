using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Farsight.Utils;

internal static class TcpInfo
{
	public enum TCP_TABLE_CLASS
	{
		TCP_TABLE_BASIC_LISTENER,
		TCP_TABLE_BASIC_CONNECTIONS,
		TCP_TABLE_BASIC_ALL,
		TCP_TABLE_OWNER_PID_LISTENER,
		TCP_TABLE_OWNER_PID_CONNECTIONS,
		TCP_TABLE_OWNER_PID_ALL,
		TCP_TABLE_OWNER_MODULE_LISTENER,
		TCP_TABLE_OWNER_MODULE_CONNECTIONS,
		TCP_TABLE_OWNER_MODULE_ALL
	}

	public enum MIB_TCP_STATE
	{
		MIB_TCP_STATE_CLOSED = 1,
		MIB_TCP_STATE_LISTEN,
		MIB_TCP_STATE_SYN_SENT,
		MIB_TCP_STATE_SYN_RCVD,
		MIB_TCP_STATE_ESTAB,
		MIB_TCP_STATE_FIN_WAIT1,
		MIB_TCP_STATE_FIN_WAIT2,
		MIB_TCP_STATE_CLOSE_WAIT,
		MIB_TCP_STATE_CLOSING,
		MIB_TCP_STATE_LAST_ACK,
		MIB_TCP_STATE_TIME_WAIT,
		MIB_TCP_STATE_DELETE_TCB
	}

	public struct MIB_TCPROW_OWNER_PID
	{
		public uint state;

		public uint localAddr;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] localPort;

		public uint remoteAddr;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] remotePort;

		public uint owningPid;

		public readonly uint ProcessId => owningPid;

		public readonly IPAddress LocalAddress => new IPAddress(localAddr);

		public readonly ushort LocalPort => BitConverter.ToUInt16(new byte[2]
		{
			localPort[1],
			localPort[0]
		}, 0);

		public readonly IPAddress RemoteAddress => new IPAddress(remoteAddr);

		public readonly ushort RemotePort => BitConverter.ToUInt16(new byte[2]
		{
			remotePort[1],
			remotePort[0]
		}, 0);

		public readonly MIB_TCP_STATE State => (MIB_TCP_STATE)state;
	}

	public struct MIB_TCPTABLE_OWNER_PID
	{
		public uint dwNumEntries;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
		public MIB_TCPROW_OWNER_PID[] table;
	}

	public const int AF_INET = 2;

	public const int AF_INET6 = 23;

	[DllImport("iphlpapi.dll", SetLastError = true)]
	private static extern uint GetExtendedTcpTable(nint pTcpTable, ref int dwOutBufLen, bool sort, int ipVersion, TCP_TABLE_CLASS tblClass, uint reserved = 0u);

	public static bool IsProcessBoundToPort(uint processId, uint port)
	{
		return GetAllTCPConnections().Any((MIB_TCPROW_OWNER_PID conn) => conn.ProcessId == processId && conn.LocalPort == port && conn.State == MIB_TCP_STATE.MIB_TCP_STATE_LISTEN);
	}

	public static bool IsConnectionOwnedBy(uint processId, IPEndPoint serverEndpoint, IPEndPoint clientEndpoint)
	{
		return GetAllTCPConnections().Any((MIB_TCPROW_OWNER_PID conn) => conn.ProcessId == processId && conn.State == MIB_TCP_STATE.MIB_TCP_STATE_ESTAB && conn.LocalAddress.Equals(serverEndpoint.Address) && conn.LocalPort == serverEndpoint.Port && conn.RemoteAddress.Equals(clientEndpoint.Address) && conn.RemotePort == clientEndpoint.Port);
	}

	public static bool IsPortInUse(short port)
	{
		return GetAllTCPConnections().Any((MIB_TCPROW_OWNER_PID conn) => conn.LocalPort == port);
	}

	public static List<MIB_TCPROW_OWNER_PID> GetAllTCPConnections()
	{
		return GetTCPConnections<MIB_TCPROW_OWNER_PID, MIB_TCPTABLE_OWNER_PID>(2);
	}

	private static List<IPR> GetTCPConnections<IPR, IPT>(int ipVersion)
	{
		int dwOutBufLen = 0;
		FieldInfo field = typeof(IPT).GetField("dwNumEntries");
		GetExtendedTcpTable(IntPtr.Zero, ref dwOutBufLen, sort: true, ipVersion, TCP_TABLE_CLASS.TCP_TABLE_OWNER_PID_ALL);
		nint num = Marshal.AllocHGlobal(dwOutBufLen);
		checked
		{
			IPR[] array;
			try
			{
				if (GetExtendedTcpTable(num, ref dwOutBufLen, sort: true, ipVersion, TCP_TABLE_CLASS.TCP_TABLE_OWNER_PID_ALL) != 0)
				{
					return new List<IPR>();
				}
				IPT val = (IPT)Marshal.PtrToStructure(num, typeof(IPT));
				int num2 = Marshal.SizeOf(typeof(IPR));
				uint valueOrDefault = ((uint?)field?.GetValue(val)).GetValueOrDefault();
				array = new IPR[valueOrDefault];
				nint num3 = (nint)(unchecked((long)num) + 4L);
				for (int i = 0; i < valueOrDefault; i++)
				{
					IPR val2 = (IPR)Marshal.PtrToStructure(num3, typeof(IPR));
					if (val2 != null)
					{
						array[i] = val2;
					}
					num3 = (nint)(unchecked((long)num3) + unchecked((long)num2));
				}
			}
			finally
			{
				Marshal.FreeHGlobal(num);
			}
			if (array == null)
			{
				return new List<IPR>();
			}
			return array.ToList();
		}
	}
}
