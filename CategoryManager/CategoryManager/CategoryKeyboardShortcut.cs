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