using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorize : MonoBehaviour {

	public Material rojo;
	public Material verde;
	public Material celeste;

	int minima;
	int maxima;

	public Cafe cafe;

	public List<MeshRenderer> rendersToChangeColor;

	void Start () {
		minima = 40;
		maxima = 80;			
	}
	void Update()
	{
		ChangeColor (cafe.temperature);
	}
	void ChangeColor(int value)
	{
		foreach (MeshRenderer mr in rendersToChangeColor) {
			if (value > minima && value < maxima) {
				mr.material = verde;
			} else if (value < minima){
				mr.material = celeste;
			} else {
				mr.material = rojo;
			}
		}	
	}
}
