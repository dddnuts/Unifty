namespace Unifty
{
    using UnityEngine;
    using UnityEditor;
    using UnityEditor.Callbacks;
    using UnityEditor.iOS.Xcode;

    public class UniftyPostProcessBuild
    {
        [PostProcessBuild]
        static void OnPostProcessBuild(BuildTarget buildTarget, string buildPath)
        {
            if (buildTarget != BuildTarget.iOS)
                return;

            var project = new PBXProject();
            var path = PBXProject.GetPBXProjectPath(buildPath);

            project.ReadFromFile(path);

            var target = project.TargetGuidByName(PBXProject.GetUnityTargetName());

            project.SetBuildProperty(target, "EMBEDDED_CONTENT_CONTAINS_SWIFT", "YES");
            project.SetBuildProperty(target, "SWIFT_OBJC_BRIDGING_HEADER", "$(SRCROOT)/../Assets/Plugins/iOS/Unifty/Unifty-Bridging-Header.h");

            project.WriteToFile(path);
        }
    }
}