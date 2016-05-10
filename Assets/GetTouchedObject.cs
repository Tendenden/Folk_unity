using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GetTouchedObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			//Debug.Log("mouseDown");
			Vector3    aTapPoint   = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);
			
			if (aCollider2d) {
				GameObject obj = aCollider2d.transform.gameObject;
				GameObject target;
				int count;
				//find child
				foreach (Transform child in obj.transform){
					if(child.tag == "CountText"){
						//targetはGameObject型
						target = child.gameObject;
						Debug.Log("obj:"+obj.name+" child:"+target);
						count = int.Parse(target.GetComponent<Text>().text);
						count++;
						target.GetComponent<Text>().text = ""+count;
					}
				}
				//Debug.Log("obj:"+obj.name+" child:"+obj.chi);

			}
		}
	}
}
