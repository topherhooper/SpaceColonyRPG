using UnityEngine;
using UnityEditor;
using SpaceColonyRPG.Colony;
using System.IO;

namespace SpaceColonyRPG.Editor
{
    public class QuickBuildingSetup : MonoBehaviour
    {
        [MenuItem("Tools/Colony/Quick Building Setup")]
        static void QuickSetup()
        {
            string path = "Assets/_Project/ScriptableObjects/Buildings/";

            // Ensure directory exists
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                AssetDatabase.Refresh();
            }

            // Create a simple test building first
            BuildingData testBuilding = ScriptableObject.CreateInstance<BuildingData>();
            testBuilding.buildingName = "Test Building";
            testBuilding.description = "A test building";
            testBuilding.category = BuildingCategory.Infrastructure;
            testBuilding.gridSize = new Vector2Int(1, 1);
            testBuilding.metalCost = 10;

            string assetPath = AssetDatabase.GenerateUniqueAssetPath(path + "TestBuilding.asset");
            AssetDatabase.CreateAsset(testBuilding, assetPath);

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            Debug.Log($"Created test building at: {assetPath}");
            Selection.activeObject = testBuilding;

            // Also log instructions
            Debug.Log("To create more buildings manually: Right-click in the Buildings folder → Create → Colony → Building Data");
        }
    }
}
