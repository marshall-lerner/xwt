// 
// ICheckBoxBackend.cs
//  
// Author:
//       Lluis Sanchez Gual <lluis@xamarin.com>
// 
// Copyright (c) 2011 Xamarin Inc
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;

namespace Xwt.Backends
{
	public interface ICheckBoxBackend: IWidgetBackend
	{
		void SetContent (IWidgetBackend widget);
		void SetContent (string label);

		/// <summary>
		/// Gets or sets whether the checkbox is checked.
		/// </summary>
		bool Active { get; set; }

		/// <summary>
		/// Gets or sets whether the checkbox is in a mixed state.
		/// </summary>
		/// <remarks>
		/// <para>
		/// Mixed can be set to <c>true</c> manually in code, even when <see cref="AllowMixed"/>
		/// is <c>false</c>. A subsequent click will clear the mixed state resulting in
		/// <see cref="Mixed"/> and <see cref="Active"/> being <c>false</c>.
		/// </para>
		/// </remarks>
		bool Mixed { get; set; }

		/// <summary>
		/// Gets or sets whether the user is allowed to reach a mixed state.
		/// </summary>
		bool AllowMixed { get; set; }
	}
	
	public interface ICheckBoxEventSink: IWidgetEventSink
	{
		void OnClicked ();
		void OnToggled ();
	}
	
	public enum CheckBoxEvent
	{
		Clicked = 1,
		Toggled = 2
	}
}

