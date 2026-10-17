using System.Threading;
using System.Threading.Tasks;

namespace Farsight.Auth;

public interface IAuthProvider
{
	Task<bool> TryPopulateUserInfoAsync(IAccessTokenSource accessTokenSource, UserInfo user_info, CancellationTokenSource cancellationTokenSource);
}
