using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerW5Demo1 : MonoBehaviour
{
    // when this stores a list of InventoryItems, it won't show up in the Inspector
    // if it stores a list of ItemW5Demo1, you have to create GameObjects for each item
    //
    // but what if these items never appear on-screen, or appear and disappear in UI?
    // does it make sense for Item to be a MonoBehaviour if it's only representing data and not behavior?
    [SerializeField] private List<InventoryItem> _inventory = new List<InventoryItem>();

    // this is UI code that doesn't really need to be in the player class,
    // I just put it here because I was coding quickly and lazily
    [SerializeField] private GameObject _inventoryUI;
    [SerializeField] private TMP_Text _itemText;

    private void Update ()
    {
        // toggles the item list text
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _inventoryUI.SetActive(!_inventoryUI.activeSelf);
            UpdateInventoryUI();
        }
    }

     private void UpdateInventoryUI()
    {
        if (_inventory.Count == 0)
        {
            _itemText.text = "Inventory is empty.";
            return;
        }
        string itemList = "Inventory:\n";
        for (int i = 0; i < _inventory.Count; i++)
        {
            itemList += $"{i + 1}. {_inventory[i].itemName}\n";
        }       

        _itemText.text = itemList;
    }
}


// I could alternatively add the [Serializable] field to this class,
// and that would make it show up in the Inspector for the Player.
// But do you think there are any downsides to these items *ONLY* being edit-able
//      from the Player GAMEOBJECT?

public class InventoryItem {
    public string itemName;
}