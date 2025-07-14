using UnityEngine;

namespace SpaceColony.Utilities
{
    /// <summary>
    /// Guide for setting up materials - Run this in Unity to see instructions
    /// </summary>
    public class MaterialSetupGuide : MonoBehaviour
    {
        [Header("Instructions")]
        [TextArea(10, 20)]
        public string instructions = @"MATERIAL SETUP GUIDE:

1. PLAYER MATERIAL
   - Name: Mat_Player
   - Base Color: Bright Blue (R:0, G:128, B:255)
   - Metallic: 0.8
   - Smoothness: 0.8

2. ENEMY MATERIAL
   - Name: Mat_Enemy
   - Base Color: Red (R:255, G:0, B:0)
   - Emission: Enabled
   - Emission Color: Dark Red (R:128, G:0, B:0)

3. BUILDING MATERIAL
   - Name: Mat_Building
   - Base Color: Gray (R:128, G:128, B:128)
   - Metallic: 0.5
   - Smoothness: 0.3

4. BUILDING GHOST VALID
   - Name: Mat_Building_Ghost_Valid
   - Surface Type: Transparent
   - Base Color: Green (R:0, G:255, B:0, A:128)
   - Render Face: Both

5. BUILDING GHOST INVALID
   - Name: Mat_Building_Ghost_Invalid
   - Surface Type: Transparent
   - Base Color: Red (R:255, G:0, B:0, A:128)
   - Render Face: Both";

        [Header("Quick Setup")]
        public bool createMaterialsFolder = true;

        void Start()
        {
            Debug.Log("=== MATERIAL SETUP GUIDE ===");
            Debug.Log(instructions);
            Debug.Log("=== END GUIDE ===");

            // This will be visible in the Inspector too!
        }
    }
}
