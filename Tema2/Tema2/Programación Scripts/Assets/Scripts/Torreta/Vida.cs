using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Vida : MonoBehaviour {
	public int puntos=100;
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "municion") {
			puntos--;
			Destroy (other.gameObject);
		}
		if (puntos == 0)
			SceneManager.LoadScene ("Fin");
	}

}
