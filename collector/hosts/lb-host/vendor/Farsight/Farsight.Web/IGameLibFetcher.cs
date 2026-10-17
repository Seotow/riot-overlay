using System;
using System.Threading;
using System.Threading.Tasks;

namespace Farsight.Web;

public interface IGameLibFetcher
{
	Task UpdateOrResetLib(Version desiredVersion, string fileLocation, DateTime? fileCreatedAt = null, CancellationToken? cancellationToken = null);

	Task UpdateFileIfOutdated(LibVersionInfo currentVersionInfo, string fileLocation, DateTime? fileCreatedAt = null, CancellationToken? cancellationToken = null);
}
