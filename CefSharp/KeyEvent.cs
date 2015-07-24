﻿// Copyright © 2010-2015 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

namespace CefSharp
{
	/// <summary>
	/// Class representing a a keyboard event.
	/// </summary>
	public struct KeyEvent
	{
		/// <summary>
		/// The type of keyboard event.
		/// </summary>
		public KeyEventType Type { get; set; }

		/// <summary>
		/// Bit flags describing any pressed modifier keys. See
		/// cef_event_flags_t for values.
		/// </summary>
		public CefEventFlags Modifiers { get; set; }

		/// <summary>
		/// The Windows key code for the key event. This value is used by the DOM
		/// specification. Sometimes it comes directly from the event (i.e. on
		/// Windows) and sometimes it's determined using a mapping function. See
		/// WebCore/platform/chromium/KeyboardCodes.h for the list of values.
		/// </summary>
		public int WindowsKeyCode { get; set; }

		/// <summary>
		/// The actual key code genenerated by the platform.
		/// </summary>
		public int NativeKeyCode { get; set; }

		/// <summary>
		/// Indicates whether the event is considered a "system key" event (see
		/// http://msdn.microsoft.com/en-us/library/ms646286(VS.85).aspx for details).
		/// This value will always be false on non-Windows platforms.
		/// </summary>
		public bool IsSystemKey { get; set; }

		/// <summary>
		/// The character generated by the keystroke.
		/// </summary>
		//char16 character { get; set; }

		///
		// Same as |character| but unmodified by any concurrently-held modifiers
		// (except shift). This is useful for working out shortcut keys.
		///
		//char16 unmodified_character { get; set; }

		///
		// True if the focus is currently on an editable field on the page. This is
		// useful for determining if standard key events should be intercepted.
		///
		public bool FocusOnEditableField { get; set; }
	}
}
