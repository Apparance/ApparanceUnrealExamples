// Copyright Apparance Studios 2021

using UnrealBuildTool;
using System.Collections.Generic;

public class UnrealExamplesTarget : TargetRules
{
	public UnrealExamplesTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "UnrealExamples" } );
	}
}
