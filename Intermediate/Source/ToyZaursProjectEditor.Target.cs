using UnrealBuildTool;

public class ToyZaursProjectEditorTarget : TargetRules
{
	public ToyZaursProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ToyZaursProject");
	}
}
