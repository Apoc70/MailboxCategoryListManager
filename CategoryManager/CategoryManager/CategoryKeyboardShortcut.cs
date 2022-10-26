// MIT License
// 
// Copyright (c) 2018 Thomas Stensitzki, Torsten Schlopsnies
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
using System.Xml.Serialization;

namespace CategoryManager
{
	public enum CategoryKeyboardShortcut: byte
	{
		[XmlEnum("0")]
		None = 0,
		[XmlEnumAttribute("1")]
		CtrlF2 = 1,
		[XmlEnumAttribute("2")]
		CtrlF3 = 2,
		[XmlEnumAttribute("3")]
		CtrlF4 = 3,
		[XmlEnumAttribute("4")]
		CtrlF5 = 4,
		[XmlEnumAttribute("5")]
		CtrlF6 = 5,
		[XmlEnumAttribute("6")]
		CtrlF7 = 6,
		[XmlEnumAttribute("7")]
		CtrlF8 = 7,
		[XmlEnumAttribute("8")]
		CtrlF9 = 8,
		[XmlEnumAttribute("9")]
		CtrlF10 = 9,
		[XmlEnumAttribute("10")]
		CtrlF11 = 10,
		[XmlEnumAttribute("11")]
		CtrlF12 = 11,
	}
}