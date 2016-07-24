using UnityEngine;
using System.Collections;

using ICE;
using ICE.World;
using ICE.World.Utilities;

using ICE.Creatures;
using ICE.Creatures.Utilities;
using ICE.Creatures.Objects;
using ICE.Creatures.EnumTypes;


namespace ICE.World.Demo
{
	[ExecuteInEditMode]
	public class DemoManager : MonoBehaviour {
		
		void Update () {
			/*
			#if UNITY_EDITOR

			if( ! Application.isPlaying )
			{
				if( LayerMask.NameToLayer( "Terrain" ) == -1 )
					ICE.World.EditorUtilities.EditorTools.AddLayer( "Terrain" );

				if( LayerMask.NameToLayer( "Obstacle" ) == -1 )
					ICE.World.EditorUtilities.EditorTools.AddLayer( "Obstacle" );
			}
				
			#endif
			*/
		}
	}
}
