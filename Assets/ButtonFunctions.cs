using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonFunctions : MonoBehaviour {

	public GameObject Prefab_Text;
	GameObject myText;
	int num1 = 0;
	void Start(){
		//Instantiate (Prefab_Text,  new Vector3(0,0,0),Quaternion.identity);// as GameObject;
		//Instantiate (Prefab_Text, transform.position, transform.rotation);// as GameObject;

		myText = (GameObject)Instantiate(Prefab_Text, transform.position, transform.rotation);
		//myText.name = "CountText";
		float b_width = GetComponent<RectTransform> ().sizeDelta.x;
		float t_width = myText.GetComponent<RectTransform> ().sizeDelta.x;
		myText.transform.Translate (new Vector3 ((int)((b_width+t_width)*0.5), 0, 0));
		myText.transform.parent = transform;

		myText.GetComponent<Text>().text = "0";
		Debug.Log ("Create");
	}
	public void StringArgFunction(string s)
	{
		Debug.Log ("StringArgFunction Called. arg="+s);
	}
	public void TestFunc() {
		Debug.Log ("testfunction!!");
		//Debug.Log (transform.position.x);
		num1++;
		//myText.GetComponent<Text>().text = ""+num1;
		//transform.FindChild("CountText").gameObject.GetComponent<Text>().text=""+num1;
//		if (transform.FindChild ("CountText").gameObject == null) {
//			Debug.Log ("not found");
//		};
		foreach (Transform child in transform){
			if(child.tag == "CountText"){
				//targetはGameObject型
				//target = child.gameObject;
				Debug.Log("child:"+child.gameObject);
				child.gameObject.GetComponent<Text>().text = "aa";
				//target.GetComponent<Text>().text = "aa";
			}
		}

		
	}
}
