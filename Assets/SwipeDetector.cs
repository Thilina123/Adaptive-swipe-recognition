using UnityEngine;
using System.Collections;

public class SwipeDetector : MonoBehaviour {

	int side=0,detectedSide=-1;
	Vector2 start,end,res;
	public Vector2 up=new Vector2(0,300),down=new Vector2(0,-300),left=new Vector2(-300,0),right=new Vector2(300,0);
	public Transform arrow;
	int count=0;
	void Start () {
		start = Vector2.zero;
		end = Vector2.zero;
		res = start - end;
	}
	void OnGUI(){
		Vector2 swipe = end - start;
		GUI.Box(new Rect(10,0,200,40),"start "+start.ToString());
		GUI.Box(new Rect(10,50,200,40),"end "+end.ToString());
		GUI.Box(new Rect(10,100,200,40),"swipe "+swipe.ToString());
		GUI.Box(new Rect(10,150,200,40),"diff with up "+(up-swipe).ToString());
		GUI.Box(new Rect(10,200,200,40),"up : "+Vector2.Distance(up,swipe));
		GUI.Box(new Rect(10,250,200,40),"right : "+Vector2.Distance(right,swipe));
		GUI.Box(new Rect(10,300,200,40),"down : "+Vector2.Distance(down,swipe));
		GUI.Box(new Rect(10,350,200,40),"left : "+Vector2.Distance(left,swipe));

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		count++;
		if (count%40==0) {
			Rotate();
				}
		switch (side) {
		case 0 : {
			break;
		}
		default:
			break;
		}
	}
	void Update(){
		if (Input.touchCount>0) {
			if (Input.GetTouch(0).phase==TouchPhase.Began) {
				start=Input.GetTouch(0).position;
			}
			if (Input.GetTouch(0).phase==TouchPhase.Ended) {
				end=Input.GetTouch(0).position;
			}
		}
	}
	void DetectSide(){
		if (true) {

				}
	}
	void OnMouseDown(){
		start = Input.mousePosition;
		Debug.Log("Clicked");
	}
	void OnMouseUp(){
		end = Input.mousePosition;
	}
	void Rotate(){
		side=Random.Range(0,4);
		arrow.gameObject.SetActive (true);
		arrow.Rotate (new Vector3 (0, 0, 90 * side));
	
	}
}
