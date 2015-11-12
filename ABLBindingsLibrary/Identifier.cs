using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Org.Altbeacon.Beacon
{
	public partial class Identifier
	{
		public int CompareTo(Java.Lang.Object another)
		{
			return CompareTo((Identifier)another);
		}
	}
}