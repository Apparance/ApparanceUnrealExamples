// Copyright Apparance Studios 2021

using UnrealBuildTool;
using System.Collections.Generic;

public class UnrealExamplesEditorTarget : TargetRules
{
	public UnrealExamplesEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "UnrealExamples" } );
	}
}
