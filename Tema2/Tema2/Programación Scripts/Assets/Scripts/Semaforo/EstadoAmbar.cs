using UnityEngine;
using System.Collections;

public class EstadoAmbar : ISMSemaforo {

	public Semaforo semaforo;

	public EstadoAmbar(Semaforo s)
	{
		semaforo = s;
	}
	public void Update () {
		semaforo.estado = Semaforo.Estado.ambar;
		semaforo.duracionEstado += Time.deltaTime;
		if (semaforo.duracionEstado > semaforo.duracionAmbar)
			aEstadoRojo ();
	}

	public void aEstadoRojo (){
		semaforo.duracionEstado = 0;
		semaforo.currentState = semaforo.estadoRojo;
	}
	public void aEstadoPrevioVerde (){

	}
	public void aEstadoAmbar (){

	}

	public void aEstadoVerde (){

	}
}
