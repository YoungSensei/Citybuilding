using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{

    public Image resourceIcon;
    public Button removeButton;

    Resource resource;

    public void AddResource(Resource newResource)
    {
        resource = newResource;

        resourceIcon.sprite = resource.icon;
        resourceIcon.enabled = true;
        removeButton.interactable = true;
    }

    public void ClearSlot ()
    {
        resource = null;

        resourceIcon.sprite = null;
        resourceIcon.enabled = false;
        removeButton.interactable = false;
    }

    public void OnRemoveButton()
    {
        Inventory.instance.Remove(resource);
    }
    
    public void UseResource ()
    {
        if(resource != null)
        {
            resource.UseResource();
            ClearSlot();
        }
    }

}
