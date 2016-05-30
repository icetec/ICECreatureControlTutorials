using UnityEngine;
using System.Collections;
using ICE;
using ICE.Creatures;
using ICE.Creatures.Objects;
using ICE.Shared;
using UnityEngine.UI;

public class CollectDemo : MonoBehaviour {

	public Text InventoryCount1;
	public Text InventoryCount2;

	public GameObject NPC1;

	private ICECreatureControl _controller_01 = null;

	//public GameObject NPC2;
	// Use this for initialization
	void Start () {
		
		if( NPC1 != null )
		{
			_controller_01 = NPC1.GetComponent<ICECreatureControl>();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
		InventoryCount1.text = _controller_01.Creature.Status.Inventory.Slots[0].Amount.ToString();
		InventoryCount2.text = _controller_01.Creature.Status.Inventory.Slots[1].Amount.ToString();
	}
}
