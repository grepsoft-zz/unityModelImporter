using UnityEditor;
using UnityEngine;

public class GSModelImporter : AssetPostprocessor
{
    void OnPreprocessModel()
    {
        ModelImporter modelImporter = assetImporter as ModelImporter;

        // Model Settings
        modelImporter.importCameras = false;
        modelImporter.importLights = false;

        // Rig settings
        modelImporter.animationType = ModelImporterAnimationType.Human;

        // Animatino Settings
        modelImporter.importAnimation = false;


        // Material
        if(!modelImporter.ExtractTextures(@"Assets/Textures"))
        {
            Debug.LogError("Failed to extract textures");
        }
    }
}
