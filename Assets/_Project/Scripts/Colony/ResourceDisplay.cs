using UnityEngine;
using UnityEngine.UI;

namespace SpaceColonyRPG.Colony
{
    public class ResourceDisplay : MonoBehaviour
    {
        public Image iconImage;
        public Text nameText;
        public Text amountText;
        public Image backgroundImage;
        
        private ResourceManager.Resource resource;
        
        public void Setup(ResourceManager.Resource res)
        {
            resource = res;
            
            if (nameText) nameText.text = res.displayName;
            if (iconImage && res.icon) iconImage.sprite = res.icon;
            if (backgroundImage) backgroundImage.color = res.displayColor * 0.3f;
            
            UpdateDisplay(res.currentAmount);
        }
        
        public void UpdateDisplay(int amount)
        {
            if (!amountText) return;
            
            if (resource.maxCapacity == int.MaxValue)
            {
                amountText.text = amount.ToString();
            }
            else
            {
                amountText.text = $"{amount}/{resource.maxCapacity}";
            }
            
            // Color feedback when at capacity
            if (amount >= resource.maxCapacity)
            {
                amountText.color = Color.yellow;
            }
            else
            {
                amountText.color = Color.white;
            }
        }
    }
}