using UnrealBuildTool;

public class ToyZaursProjectClientTarget : TargetRules
{
	public ToyZaursProjectClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("ToyZaursProject");
	}
}
