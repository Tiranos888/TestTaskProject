using UnrealBuildTool;

public class TestTaskProjectTarget : TargetRules
{
	public TestTaskProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TestTaskProject");
	}
}
