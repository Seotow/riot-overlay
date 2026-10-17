namespace Farsight.Replay;

public record PlaybackState(bool Paused, bool Seeking, float Time, float Speed, float Length);
