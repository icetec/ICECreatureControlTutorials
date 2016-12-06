// ##############################################################################
//
// ICECreatureDemoMenu.cs
// Version 1.3.5
//
// Copyrights © Pit Vetterick, ICE Technologies Consulting LTD. All Rights Reserved.
// http://www.icecreaturecontrol.com
// mailto:support@icecreaturecontrol.com
// 
// Unity Asset Store End User License Agreement (EULA)
// http://unity3d.com/legal/as_terms
//
// ##############################################################################

using UnityEditor;
using UnityEngine;

using ICE;
using ICE.World.EditorUtilities;

using ICE.Creatures;
using ICE.Creatures.Utilities;
using ICE.Creatures.Objects;
using ICE.Creatures.EnumTypes;
using ICE.Creatures.Attributes;
using ICE.Creatures.EditorInfos;
using ICE.Creatures.Windows;

namespace ICE.Creatures.Menus
{
	public class ICECreatureDemoMenu : MonoBehaviour {

		public ICECreatureDemoMenu(){

			#if UNITY_EDITOR

			if( ! Application.isPlaying )
			{
				if( LayerMask.NameToLayer( "WalkableSurface" ) == -1 )
					ICE.World.EditorUtilities.EditorTools.AddLayer( "WalkableSurface" );

				if( LayerMask.NameToLayer( "Obstacle" ) == -1 )
					ICE.World.EditorUtilities.EditorTools.AddLayer( "Obstacle" );
			}

			#endif
		}

		[MenuItem ( "ICE/ICE Creature Control/Demos/Assign Demo Layer", false, 9300 )]
		static void AssignDemoLayer() 
		{
			if( ! Application.isPlaying )
			{
				if( LayerMask.NameToLayer( "WalkableSurface" ) == -1 )
					ICE.World.EditorUtilities.EditorTools.AddLayer( "WalkableSurface" );

				if( LayerMask.NameToLayer( "Obstacle" ) == -1 )
					ICE.World.EditorUtilities.EditorTools.AddLayer( "Obstacle" );
			}
		}
		/*
		// ATTRIBUTES
		[MenuItem ( "ICE/ICE Creature Control/Demos/Attributes/Add Target Attribute", false, 1300 )]
		static void AddTargetAttribute() 
		{
			GameObject _object = Selection.activeObject as GameObject;

			if( _object != null && _object.GetComponent<ICECreatureTargetAttribute>() == null )
				_object.AddComponent<ICECreatureTargetAttribute>();
		}

		[MenuItem ( "ICE/ICE Creature Control/Components/Attributes/Add Target Attribute", true)]
		static bool ValidateTargetAttribute(){
			return ValidateAttributeObject();
		}

		[MenuItem ( "ICE/ICE Creature Control/Components/Attributes/Add Odour Attribute", false, 1300 )]
		static void AddOdourAttribute() 
		{
			GameObject _object = Selection.activeObject as GameObject;

			if( _object != null && _object.GetComponent<ICECreatureOdourAttribute>() == null )
				_object.AddComponent<ICECreatureOdourAttribute>();
		}

		[MenuItem ( "ICE/ICE Creature Control/Components/Attributes/Add Odour Attribute", true)]
		static bool ValidateOdourAttribute(){
			return ValidateAttributeObject();
		}

		static bool ValidateAttributeObject() 
		{
			GameObject _obj = Selection.activeObject as GameObject;

			if( _obj != null && 
				_obj.GetComponent<ICECreatureControl>() == null && 
				_obj.GetComponent<ICECreatureRegister>() == null )
				return true;
			else
				return false;
		}*/
	}
}