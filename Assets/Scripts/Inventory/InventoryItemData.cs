using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory
{
    [CreateAssetMenu(fileName = "Inventory Item Data File", menuName = "Custom/Inventory/Inventory Item Data File")]
    [System.Serializable]
    public class InventoryItemData : ScriptableObject
    {
        [SerializeField]
        private ItemTypes itemType = 0;
        public ItemTypes ItemType { get { return itemType; } }

        [SerializeField]
        private string itemName = "";
        public string ItemName { get { return itemName; } }

        [SerializeField]
        private Sprite sprite = null;
        public Sprite Sprite { get { return sprite; } }

        [SerializeField]
        private int sizeX = 1;
        public int SizeX { get { return sizeX; } }

        [SerializeField]
        private int sizeY = 1;
        public int SizeY { get { return sizeY; } }

        public int Size { get { return SizeX * SizeY; } }
    }
}
