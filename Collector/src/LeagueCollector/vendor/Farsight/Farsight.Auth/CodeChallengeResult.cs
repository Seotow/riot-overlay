namespace Farsight.Auth;

public sealed record CodeChallengeResult(string SignatureBase64, ulong[] FeatureBits);
