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
using System;
using System.Xml.Serialization;

namespace CategoryManager
{
	/// <remarks/>
	[Serializable]
	[XmlType(Namespace = "CategoryList.xsd")]
	public class Category
	{
		/// <remarks/>
		[XmlAttribute("name")]
		public string Name { get; set; }

		/// <remarks/>
		[XmlAttribute("color")]
		public CategoryColor Color { get; set; }

		/// <remarks/>
		[XmlAttribute("keyboardShortcut")]
		public CategoryKeyboardShortcut KeyboardShortcut { get; set; }

		/// <remarks/>
		[XmlAttribute("usageCount")]
		public byte UsageCount { get; set; }

		/// <remarks/>
		[XmlAttribute("lastTimeUsedNotes")]
		public DateTime LastTimeUsedNotes { get; set; }

		/// <remarks/>
		[XmlAttribute("lastTimeUsedJournal")]
		public DateTime LastTimeUsedJournal { get; set; }

		/// <remarks/>
		[XmlAttribute("lastTimeUsedContacts")]
		public DateTime LastTimeUsedContacts { get; set; }

		/// <remarks/>
		[XmlAttribute("lastTimeUsedTasks")]
		public DateTime LastTimeUsedTasks { get; set; }

		/// <remarks/>
		[XmlAttribute("lastTimeUsedCalendar")]
		public DateTime LastTimeUsedCalendar { get; set; }

		/// <remarks/>
		[XmlAttribute("lastTimeUsedMail")]
		public DateTime LastTimeUsedMail { get; set; }

		/// <remarks/>
		[XmlAttribute("lastTimeUsed")]
		public DateTime LastTimeUsed { get; set; }

		/// <remarks/>
		[XmlAttribute("lastSessionUsed")]
		public byte LastSessionUsed { get; set; }

		/// <remarks/>
		[XmlAttribute("guid")]
		public Guid Id { get; set; }

		/// <remarks/>
		[XmlAttribute("renameOnFirstUse")]
		public byte RenameOnFirstUse { get; set; }

		/// <remarks/>
		[XmlIgnore]
		public bool RenameOnFirstUseSpecified { get; set; }


		public Category()
		{
		}

		public Category(string name, CategoryColor color, CategoryKeyboardShortcut keyboardShortcut): this()
		{
			Name = name;
			Color = color;
			KeyboardShortcut = keyboardShortcut;
			Id = Guid.NewGuid();
		}
	}
}