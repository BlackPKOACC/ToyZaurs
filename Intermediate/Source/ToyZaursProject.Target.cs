using UnrealBuildTool;

public class ToyZaursProjectTarget : TargetRules
{
	public ToyZaursProjectTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ToyZaursProject");
	}
}
