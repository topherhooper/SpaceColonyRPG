using UnityEngine;
using UnityEditor;
using SpaceColonyRPG.Colony;

namespace SpaceColonyRPG.Editor
{
    public class BuildingDataCreator : EditorWindow
    {
        [MenuItem("Tools/Colony/Create Default Buildings")]
        static void CreateDefaultBuildings()
        {
            string path = "Assets/_Project/ScriptableObjects/Buildings/";
            
            // Ensure directory exists
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
                AssetDatabase.Refresh();
            }
            
            // Check if assets already exist
            string[] existingAssets = AssetDatabase.FindAssets("t:BuildingData", new[] { path });
            if (existingAssets.Length > 0)
            {
                if (!EditorUtility.DisplayDialog("Buildings Already Exist", 
                    "Building assets already exist in this folder. Do you want to overwrite them?", 
                    "Overwrite", "Cancel"))
                {
                    return;
                }
            }
            
            // Command Center
            BuildingData commandCenter = ScriptableObject.CreateInstance<BuildingData>();
            commandCenter.buildingName = "Command Center";
            commandCenter.description = "The heart of your colony. Required for all operations.";
            commandCenter.category = BuildingCategory.Infrastructure;
            commandCenter.gridSize = new Vector2Int(3, 3);
            commandCenter.metalCost = 200;
            commandCenter.requiredColonyLevel = 1;
            commandCenter.housingCapacity = 2;
            CreateBuildingAsset(commandCenter, path + "CommandCenter.asset");
            
            // Solar Panel
            BuildingData solarPanel = ScriptableObject.CreateInstance<BuildingData>();
            solarPanel.buildingName = "Solar Panel";
            solarPanel.description = "Generates energy from solar radiation.";
            solarPanel.category = BuildingCategory.Infrastructure;
            solarPanel.gridSize = new Vector2Int(1, 1);
            solarPanel.metalCost = 50;
            solarPanel.resourceProduction = new BuildingData.ResourceProduction[]
            {
                new BuildingData.ResourceProduction { resourceType = ResourceType.Energy, amountPerMinute = 10 }
            };
            CreateBuildingAsset(solarPanel, path + "SolarPanel.asset");
            
            // Metal Mine
            BuildingData metalMine = ScriptableObject.CreateInstance<BuildingData>();
            metalMine.buildingName = "Metal Mine";
            metalMine.description = "Extracts metal from underground deposits.";
            metalMine.category = BuildingCategory.Production;
            metalMine.gridSize = new Vector2Int(2, 2);
            metalMine.metalCost = 100;
            metalMine.energyConsumption = 5;
            metalMine.colonistsRequired = 1;
            metalMine.resourceProduction = new BuildingData.ResourceProduction[]
            {
                new BuildingData.ResourceProduction { resourceType = ResourceType.Metal, amountPerMinute = 20 }
            };
            CreateBuildingAsset(metalMine, path + "MetalMine.asset");
            
            // Habitat Pod
            BuildingData habitatPod = ScriptableObject.CreateInstance<BuildingData>();
            habitatPod.buildingName = "Habitat Pod";
            habitatPod.description = "Provides housing for colonists.";
            habitatPod.category = BuildingCategory.Infrastructure;
            habitatPod.gridSize = new Vector2Int(2, 2);
            habitatPod.metalCost = 75;
            habitatPod.energyConsumption = 2;
            habitatPod.housingCapacity = 4;
            CreateBuildingAsset(habitatPod, path + "HabitatPod.asset");
            
            // Research Lab
            BuildingData researchLab = ScriptableObject.CreateInstance<BuildingData>();
            researchLab.buildingName = "Research Lab";
            researchLab.description = "Generates research points for unlocking new technologies.";
            researchLab.category = BuildingCategory.Research;
            researchLab.gridSize = new Vector2Int(2, 2);
            researchLab.metalCost = 150;
            researchLab.energyConsumption = 10;
            researchLab.colonistsRequired = 2;
            researchLab.requiredColonyLevel = 2;
            researchLab.resourceProduction = new BuildingData.ResourceProduction[]
            {
                new BuildingData.ResourceProduction { resourceType = ResourceType.Research, amountPerMinute = 5 }
            };
            CreateBuildingAsset(researchLab, path + "ResearchLab.asset");
            
            // Defense Tower
            BuildingData defenseTower = ScriptableObject.CreateInstance<BuildingData>();
            defenseTower.buildingName = "Defense Tower";
            defenseTower.description = "Provides defensive capabilities against raids.";
            defenseTower.category = BuildingCategory.Defense;
            defenseTower.gridSize = new Vector2Int(1, 1);
            defenseTower.metalCost = 100;
            defenseTower.energyConsumption = 5;
            defenseTower.raidDamageBonus = 0.1f;
            CreateBuildingAsset(defenseTower, path + "DefenseTower.asset");
            
            // Shield Generator
            BuildingData shieldGen = ScriptableObject.CreateInstance<BuildingData>();
            shieldGen.buildingName = "Shield Generator";
            shieldGen.description = "Provides shields for colonists during raids.";
            shieldGen.category = BuildingCategory.Defense;
            shieldGen.gridSize = new Vector2Int(2, 2);
            shieldGen.metalCost = 200;
            shieldGen.energyConsumption = 15;
            shieldGen.requiredColonyLevel = 3;
            shieldGen.raidShieldBonus = 0.2f;
            CreateBuildingAsset(shieldGen, path + "ShieldGenerator.asset");
            
            // Medical Bay
            BuildingData medicalBay = ScriptableObject.CreateInstance<BuildingData>();
            medicalBay.buildingName = "Medical Bay";
            medicalBay.description = "Provides health regeneration during raids.";
            medicalBay.category = BuildingCategory.Infrastructure;
            medicalBay.gridSize = new Vector2Int(2, 2);
            medicalBay.metalCost = 120;
            medicalBay.energyConsumption = 8;
            medicalBay.colonistsRequired = 1;
            medicalBay.requiredColonyLevel = 2;
            medicalBay.raidHealthRegenBonus = 0.15f;
            CreateBuildingAsset(medicalBay, path + "MedicalBay.asset");
            
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            
            Debug.Log("Default building data assets created!");
        }
        
        static void CreateBuildingAsset(BuildingData buildingData, string assetPath)
        {
            try
            {
                // Delete existing asset if it exists
                if (AssetDatabase.LoadAssetAtPath<BuildingData>(assetPath) != null)
                {
                    AssetDatabase.DeleteAsset(assetPath);
                }
                
                AssetDatabase.CreateAsset(buildingData, assetPath);
                Debug.Log($"Created: {assetPath}");
            }
            catch (System.Exception e)
            {
                Debug.LogError($"Failed to create {assetPath}: {e.Message}");
            }
        }
    }
}