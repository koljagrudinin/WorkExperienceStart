using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NGRU.ExpSite.Web.Factory;
using Owin;

namespace NGRU.ExpSite.Web
{
	public partial class Startup
	{
		public void ConfigureUnity(IAppBuilder app)
		{
			ControllerBuilder.Current.SetControllerFactory(typeof (DynamicControllerFactory));
		}
	}
}