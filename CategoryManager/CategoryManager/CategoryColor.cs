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
	public enum CategoryColor: byte
	{
		[XmlEnum("-1")]
		None,
		[XmlEnumAttribute("0")]
		Red,
		[XmlEnumAttribute("1")]
		Orange,
		[XmlEnumAttribute("2")]
		Peach,
		[XmlEnumAttribute("3")]
		Yellow,
		[XmlEnumAttribute("4")]
		Green,
		[XmlEnumAttribute("5")]
		Teal,
		[XmlEnumAttribute("6")]
		Olive,
		[XmlEnumAttribute("7")]
		Blue,
		[XmlEnumAttribute("8")]
		Purple,
		[XmlEnumAttribute("9")]
		Maroon,
		[XmlEnumAttribute("10")]
		Steel,
		[XmlEnumAttribute("11")]
		DarkSteel,
		[XmlEnumAttribute("12")]
		Gray,
		[XmlEnumAttribute("13")]
		DarkGray,
		[XmlEnumAttribute("14")]
		Black,
		[XmlEnumAttribute("15")]
		DarkRed,
		[XmlEnumAttribute("16")]
		DarkOrange,
		[XmlEnumAttribute("17")]
		DarkPeach,
		[XmlEnumAttribute("18")]
		DarkYellow,
		[XmlEnumAttribute("19")]
		DarkGreen,
		[XmlEnumAttribute("20")]
		DarkTeal,
		[XmlEnumAttribute("21")]
		DarkOlive,
		[XmlEnumAttribute("22")]
		DarkBlue,
		[XmlEnumAttribute("23")]
		DarkPurple,
		[XmlEnumAttribute("24")]
		DarkMaroon
	}
}