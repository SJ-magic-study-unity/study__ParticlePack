/************************************************************
description
	例えば、FlameThrowerの場合、
		FlameThrower
			Smoke
			FireEmbers (3)
	と言う親子構成になっている。
	
	子供の方がDurationが長いことが多い。
	本scriptを子供側にattachすれば、particle動作が終わると同時にrootからDestroyしてくれる。
	
	transform.root.gameObject は、親がいない場合は自分自身を返す(not null)ので、
	子供がない場合でもok.
************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************************
************************************************************/
public class ParticlePack_AutoDestroyEffect : MonoBehaviour
{
	private GameObject _parent;
	ParticleSystem particle;
	
	/******************************
	******************************/
	void Start()
	{
		_parent = transform.root.gameObject;
		particle = GetComponent<ParticleSystem>();
	}
	
	/******************************
	******************************/
	void Update()
	{
		// if(particle.isPlaying == false) Destroy(gameObject);
		if(particle.isPlaying == false) Destroy(_parent);
	}
}
