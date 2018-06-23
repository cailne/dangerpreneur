using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class MsItem : ScriptableObject {

	new public string name = "New Item";
	public Sprite icon = null;
	public bool isDefaultItem = false;
	public int value;
}
