using UnrealBuildTool;

public class ToyZaursProjectServerTarget : TargetRules
{
	public ToyZaursProjectServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ToyZaursProject");
	}
}
