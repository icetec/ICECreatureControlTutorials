using UnityEngine;
using System.Collections;
using ICE;
using ICE.Creatures;
using ICE.Creatures.EnumTypes;
using ICE.Creatures.Objects;
using ICE.World.Utilities;
using ICE.Shared;

[ExecuteInEditMode]
public class DemoManager : MonoBehaviour {
	
	void Update () {
	
		#if UNITY_EDITOR

		if( ! Application.isPlaying )
		{
			if( LayerMask.NameToLayer( "Terrain" ) == -1 )
				EditorTools.AddLayer( "Terrain" );

			if( LayerMask.NameToLayer( "Obstacle" ) == -1 )
				EditorTools.AddLayer( "Obstacle" );
		}
			
		#endif
	}
}
