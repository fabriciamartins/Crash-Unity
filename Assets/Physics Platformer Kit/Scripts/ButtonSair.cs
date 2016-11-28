using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonSair : MonoBehaviour {

	private Button button;

	// Use this for initialization
	void Start () {
		button = GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			button.onClick.AddListener (Sair);
		}
	}

	void Sair(){
		Application.Quit ();
	}
}
