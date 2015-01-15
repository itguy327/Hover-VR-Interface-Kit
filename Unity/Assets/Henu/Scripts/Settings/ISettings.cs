﻿using System;
using Henu.Navigation;

namespace Henu.Settings {

	/*================================================================================================*/
	public interface ISettings {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		Type GetUiArcSegmentRendererType(NavItem pNavItem);

		/*--------------------------------------------------------------------------------------------*/
		Type GetUiCursorRendererType();

		/*--------------------------------------------------------------------------------------------*/
		Type GetUiPalmRendererType();

		/*--------------------------------------------------------------------------------------------*/
		ArcSegmentSettings GetArcSegmentSettings(NavItem pNavItem);
		
		/*--------------------------------------------------------------------------------------------*/
		CursorSettings GetCursorSettings();

		/*--------------------------------------------------------------------------------------------*/
		InteractionSettings GetInteractionSettings();

	}

}
