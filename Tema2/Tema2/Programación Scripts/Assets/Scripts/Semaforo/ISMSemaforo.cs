using UnityEngine;
using System.Collections;

public interface ISMSemaforo  {


	// Update is called once per frame
	void Update ();

	void aEstadoRojo ();
	void aEstadoPrevioVerde ();
	void aEstadoAmbar ();
	void aEstadoVerde ();

}
