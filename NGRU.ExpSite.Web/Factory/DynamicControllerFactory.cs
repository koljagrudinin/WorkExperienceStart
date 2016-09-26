using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Routing;
using System.Web.SessionState;
using Microsoft.Practices.ServiceLocation;

namespace NGRU.ExpSite.Web.Factory
{
	public class DynamicActionInvoker : ControllerActionInvoker
	{
		private readonly IServiceLocator _Locator;

		public DynamicActionInvoker(IServiceLocator locator)
		{
			_Locator = locator;
		}

		protected override ActionResult CreateActionResult(ControllerContext controllerContext,
			ActionDescriptor actionDescriptor,
			object actionReturnValue)
		{
			return base.CreateActionResult(controllerContext, actionDescriptor, actionReturnValue);
		}

		protected override ActionDescriptor FindAction(ControllerContext controllerContext,
			ControllerDescriptor controllerDescriptor,
			string actionName)
		{
			return base.FindAction(controllerContext, controllerDescriptor, actionName);
		}

		protected override ControllerDescriptor GetControllerDescriptor(ControllerContext controllerContext)
		{
			return base.GetControllerDescriptor(controllerContext);
		}

		protected override FilterInfo GetFilters(ControllerContext controllerContext, ActionDescriptor actionDescriptor)
		{
			return base.GetFilters(controllerContext, actionDescriptor);
		}

		protected override object GetParameterValue(ControllerContext controllerContext,
			ParameterDescriptor parameterDescriptor)
		{
			return base.GetParameterValue(controllerContext, parameterDescriptor);
		}

		protected override IDictionary<string, object> GetParameterValues(ControllerContext controllerContext,
			ActionDescriptor actionDescriptor)
		{
			return base.GetParameterValues(controllerContext, actionDescriptor);
		}

		public override bool InvokeAction(ControllerContext controllerContext, string actionName)
		{
			return base.InvokeAction(controllerContext, actionName);
		}

		protected override ActionResult InvokeActionMethod(ControllerContext controllerContext,
			ActionDescriptor actionDescriptor,
			IDictionary<string, object> parameters)
		{
			return base.InvokeActionMethod(controllerContext, actionDescriptor, parameters);
		}

		protected override ActionExecutedContext InvokeActionMethodWithFilters(ControllerContext controllerContext,
			IList<IActionFilter> filters,
			ActionDescriptor actionDescriptor, IDictionary<string, object> parameters)
		{
			return base.InvokeActionMethodWithFilters(controllerContext, filters, actionDescriptor, parameters);
		}

		protected override void InvokeActionResult(ControllerContext controllerContext, ActionResult actionResult)
		{
			base.InvokeActionResult(controllerContext, actionResult);
		}

		protected override ResultExecutedContext InvokeActionResultWithFilters(ControllerContext controllerContext,
			IList<IResultFilter> filters,
			ActionResult actionResult)
		{
			return base.InvokeActionResultWithFilters(controllerContext, filters, actionResult);
		}

		protected override AuthenticationContext InvokeAuthenticationFilters(ControllerContext controllerContext,
			IList<IAuthenticationFilter> filters,
			ActionDescriptor actionDescriptor)
		{
			return base.InvokeAuthenticationFilters(controllerContext, filters, actionDescriptor);
		}

		protected override AuthenticationChallengeContext InvokeAuthenticationFiltersChallenge(
			ControllerContext controllerContext, IList<IAuthenticationFilter> filters,
			ActionDescriptor actionDescriptor, ActionResult result)
		{
			return base.InvokeAuthenticationFiltersChallenge(controllerContext, filters, actionDescriptor, result);
		}

		protected override AuthorizationContext InvokeAuthorizationFilters(ControllerContext controllerContext,
			IList<IAuthorizationFilter> filters,
			ActionDescriptor actionDescriptor)
		{
			return base.InvokeAuthorizationFilters(controllerContext, filters, actionDescriptor);
		}

		protected override ExceptionContext InvokeExceptionFilters(ControllerContext controllerContext,
			IList<IExceptionFilter> filters, Exception exception)
		{
			return base.InvokeExceptionFilters(controllerContext, filters, exception);
		}
	}

	public class DynamicControllerFactory : DefaultControllerFactory
	{
		private readonly IServiceLocator _Locator;

		public DynamicControllerFactory(IServiceLocator locator)
		{
			_Locator = locator;
		}

		public override IController CreateController(RequestContext requestContext, string controllerName)
		{
			return base.CreateController(requestContext, controllerName);
		}

		protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
		{
			return base.GetControllerInstance(requestContext, controllerType);
		}

		protected override SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, Type controllerType)
		{
			return base.GetControllerSessionBehavior(requestContext, controllerType);
		}

		protected override Type GetControllerType(RequestContext requestContext, string controllerName)
		{
			return base.GetControllerType(requestContext, controllerName);
		}

		public override void ReleaseController(IController controller)
		{
			base.ReleaseController(controller);
		}
	}
}